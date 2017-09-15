using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using GpsMonitor.Application.Interfaces;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Mvc.Controllers.Shared;
using GpsMonitor.Mvc.Models;
using GpsMonitor.Mvc.Models.Shared;

namespace GpsMonitor.Mvc.Controllers
{
    public class UsuarioController : CustomController
    {
        #region Fields

        private readonly IUsuarioApp _usuarioApp;
        private readonly IPerfilApp _perfilApp;
        private readonly IEmailApp _emailApp;
        private readonly string _from = ConfigurationManager.AppSettings["MailFrom"];

        #endregion

        #region Constructors

        public UsuarioController(IUsuarioApp usuarioApp, IPerfilApp perfilApp, IEmailApp emailApp)
        {
            _usuarioApp = usuarioApp;
            _perfilApp = perfilApp;
            _emailApp = emailApp;
        }

        #endregion

        #region Actions

        // GET: Usuario
        [Authorize(Roles = "Administrador")]
        //[IsAuthorize("Usuario", "Index")]
        public ActionResult Index(int idPag = 0)
        {
            try
            {
                var model = new UsuarioModel();

                var paginar = new Pagination
                {
                    PaginaAtual = idPag
                };

                var modelList = _usuarioApp.GetUsuariosPaging(ref paginar)
                    .Select(item => model.MapperEntityToModel(item)).ToList();
                
                ViewBag.PaginaAtual = paginar.PaginaAtual;
                ViewBag.QtdePaginas = paginar.QtdePaginas;

                return View(modelList);
            }
            catch (Exception e)
            {
                ShowMessageDialog("Ocorreu um problema ao tentar listar os usuário", e);
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.PerfilId = new SelectList(_perfilApp.GetAll(), "PerfilId", "Descricao");
            return View(new UsuarioModel());
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Senha = _usuarioApp.GetCodigoRecover();
                    model.CodigoRecover = _usuarioApp.GetCodigoRecover();
                    _usuarioApp.Add(model.MapperModelToEntity(model));

                    try
                    {
                        var modelEmail = new Email
                        {
                            From = _from,
                            To = new List<string> {model.Email},
                            Subject = "Imaftec - Cadastramento no Portal",
                            Body = $"Caro(a) {model.Nome},<br><br> Foi realizado cadastramento no portal para seu usuário, " +
                                   $"conforme informações a seguir, <br> Login: {model.Login}<br> Senha: {model.Senha}"
                        };

                        _emailApp.SendEmail(modelEmail);
                    }
                    catch (Exception e)
                    {
                        ShowMessageDialog("Usuário cadastrado, porém ocorreu um erro ao enviar o email", e);
                        return RedirectToAction("Index");
                    }

                    ShowMessageDialog("Usuário cadastrado, e e-mail enviado!", Message.MessageKind.Success);
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception e)
            {
                ShowMessageDialog("Ocorreu um problema ao tentar cadastrar usuário", e);
            }

            return RedirectToAction("Index");
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new UsuarioModel();
            var usuario = _usuarioApp.GetId(id);
            ViewBag.PerfilId = new SelectList(_perfilApp.GetAll(), "PerfilId", "Descricao", usuario.PerfilId);
            return View(model.MapperEntityToModel(usuario));
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Senha = $"{_usuarioApp.GetSenha(model.UsuarioId)}";
                    _usuarioApp.Update(model.MapperModelToEntity(model));

                    ShowMessageDialog("Usuário Atualizado!", Message.MessageKind.Success);
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception e)
            {
                ShowMessageDialog("Ocorreu um problema ao tentar atualizar os dados de usuário", e);
            }

            return RedirectToAction("Index");
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var usuario = _usuarioApp.GetId(id);
                _usuarioApp.Remove(usuario);

                ShowMessageDialog("Usuário Removido!", Message.MessageKind.Success);
            }
            catch (Exception e)
            {
                ShowMessageDialog("Ocorreu um problema ao tentar excluir os dados do usuário", e);
            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}
