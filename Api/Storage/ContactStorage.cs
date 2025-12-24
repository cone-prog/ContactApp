public class ContactStorage
{
    public List<Contact> contacts { get; set; }

    public ContactStorage()
    {
        this.contacts = new();

        for (int i = 0; i < 3; i++)
        {
            contacts.Add(new Contact() { Id = 1, Email = "dasd", Name = "Peka" });
        }
    }


}