using System;
using MongoDB.Driver.GeoJsonObjectModel;
using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Data.Collections
{
    public class NewBaseType
    {
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }

    public class Infectado : NewBaseType
    {
        public Infectado(DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }
        public DateTime DataNascimento {get; set;}
        public string Sexo {get; set;}
    }
}