import RowTableContact from "./Components/RowTableContact";

const TableContact = (props) => {
    return (
        <table className="table table-hover">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Имя контакта</th>
                    <th>E-mail</th>
                </tr>
            </thead>
            <tbody>{
                props.contacts.map(item =>
                (
                    <RowTableContact
                        key={item.id}
                        id={item.id}
                        name={item.name}
                        email={item.email}
                        deleteContact={props.deleteContact}
                    />
                )
                )
            }
            </tbody>
        </table>
    );
}
export default TableContact; 