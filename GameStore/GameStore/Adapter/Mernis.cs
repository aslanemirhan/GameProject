using GameStore.Abstracts;
using GameStore.Entities;
using MernisServiceAdapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Adapter
{
    public class Mernis : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(gamer.NationalityId),
                    gamer.FirstName,
                    gamer.LastName,
                    gamer.DateOfBirth.Year
                    ))
                ).Result.Body.TCKimlikNoDogrulaResult;



        }
    }
}
