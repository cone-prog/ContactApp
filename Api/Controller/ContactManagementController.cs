using Microsoft.AspNetCore.Mvc;

class ContactManagementController : BaseController
{
    private ContactStorage contactStorage;

    public ContactManagementController(ContactStorage contactStorage)
    {
        this.contactStorage = contactStorage;
    }

    [HttpPost("contacts")]
    public void Create([FromBody] Contact contact)
    {
        contactStorage.contacts.Add(contact);
    }

    [HttpGet("contacts")]
    public List<Contact> GetContacts()
    {
        return contactStorage.contacts;
    }
}