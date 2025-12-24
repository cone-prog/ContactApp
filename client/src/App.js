import TableContact from "./layout/TableContact/TableContact";
import React, { useState } from "react";

const App = () => {
  const addContact = () => {
    const item = {
      id: 1,
      name: "21423",
      email: "24234"
    };
    setContacts([...contacts, item]);

  }

  const [contacts, setContacts] = useState([
    { id: 1, name: "sdfsdf", email: "fsfsdfsfdf" },
    { id: 1, name: "sdfsdf", email: "fsfsdfsfdf" },
    { id: 1, name: "sdfsdf", email: "fsfsdfsfdf" }
  ]);
  return (
    <div className="container mt-5">
      <div className="card">
        <div className="card-header">
          <h1>Список контактов</h1>
        </div>
        <div className="card-body">
          <TableContact contacts={contacts} />
          <div>
            <button className="btn btn-primary"
              onClick={() => addContact()}>
              Добавить контакт
            </button>
          </div>
        </div>
      </div>

    </div>
  );
}

export default App; 
