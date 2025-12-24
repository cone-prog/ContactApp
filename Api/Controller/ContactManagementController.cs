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

    [HttpDelete("contacts/{id}")]
    public void DeleteContact(int id)
    {
        Contact contact;
        for (int i = 0; i < contactStorage.contacts.Count(); i++)
        {
            if (i == contactStorage.contacts[i].Id)
            {
                contact = contactStorage.contacts[i];
                contactStorage.contacts.Remove(contact);
                return;
            }
        }
    }
}