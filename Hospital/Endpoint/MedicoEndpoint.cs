using FastEndpoints;
using Hospital.Request;
using Hospital.Responses;

namespace Hospital.Endpoint
{
    public class MedicoEndpoint : Endpoint<MedicoRequest, MedicosResponse>
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("medico/{idMedico}");
            AllowAnonymous();
        }

        public override Task HandleAsync(MedicoRequest req, CancellationToken ct)
        {
            
        }
    }
}
