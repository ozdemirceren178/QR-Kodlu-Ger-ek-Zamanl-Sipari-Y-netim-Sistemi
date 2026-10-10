using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConctactService _conctactService;
        private readonly IMapper _mapper;

        public ContactController(IConctactService conctactService, IMapper mapper)
        {
            _conctactService = conctactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_conctactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _conctactService.TAdd(new Contact()
            {
                FooterDescription= createContactDto.FooterDescription,
                Location=createContactDto.Location,
                Mail=createContactDto.Mail,
                Phone= createContactDto.Phone
            });
            return Ok("İletişim bilgisi eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _conctactService.TGetByID(id);
            _conctactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _conctactService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _conctactService.TUpdate(new Contact()
            {
             ContactID =updateContactDto.ContactID,
             FooterDescription = updateContactDto.FooterDescription,
             Location= updateContactDto.Location,
             Mail=updateContactDto.Mail,
             Phone= updateContactDto.Phone
            });
            return Ok("İletişim Bilgisi Güncellendi");

        }
    }
}
