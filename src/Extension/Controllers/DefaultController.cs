// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.Abstractions;
using Extension.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Extension.Controllers
{
  public class DefaultController : Controller
  {
    private IStorage storage;

    public DefaultController(IStorage storage)
    {
      this.storage = storage;
    }

    public ActionResult Index()
    {
      return this.View(this.storage.GetRepository<IPersonRepository>().All());
    }
  }
}