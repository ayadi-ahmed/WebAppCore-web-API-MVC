﻿namespace WebApplicationCoreGLSID.Models
{
    public class SousCategorie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public  Guid categorieId { get; set; }
        public Categorie categorie { get; set; }
    }
}