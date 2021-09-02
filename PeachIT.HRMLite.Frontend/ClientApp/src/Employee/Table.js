import React, { Component } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';
class Table extends Component {
    constructor(props) {
        super(props);
    }

    DeleteEmployee = () => {
        /*axios.delete('https://localhost:44378/api/Employee/DeleteEmployee?id=' + this.props.obj.Id)*/
        axios.delete('https://localhost:5001/api/employee/deleteemployee?Id=' + this.props.obj.id)
            .then(json => {
                if (json.status === 200) {
                    alert('Record deleted successfully!!');
                   /* this.props.history.push('/EmployeeList')*/
                }
            })
    }
    render() {
   
        return (
            <tr>
                <td>
                    {this.props.obj.name}
                </td>
                <td>
                    {this.props.obj.address}
                </td>
                <td>
                    <Link to={"/Edit/" + this.props.obj.Id} className="btn btn-success">Edit</Link>
                </td>
                <td>
                    <button type="button" onClick={this.DeleteEmployee} className="btn btn-danger">Delete</button>
                </td>
            </tr>
        );
    }
}

export default Table;