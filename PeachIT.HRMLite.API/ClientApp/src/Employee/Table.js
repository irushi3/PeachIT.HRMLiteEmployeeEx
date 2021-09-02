import React, { Component } from 'react';
import axios from 'axios';
import { Link } from 'react-router-dom';

class Table extends Component {
    constructor(props) {
        super(props);
        /*this.DeleteEmployee = this.DeleteEmployee.bind(this);*/
        this.state = { business: [] };
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
                    <Link to={"/EditEmployee/" + this.props.obj.id} className="btn btn-success">Edit</Link>
                </td>
                <td>
                    <button type="button" onClick={() => this.props.del(this.props.obj.id)} className="btn btn-danger">Delete</button>
                </td>
            </tr>
        );
    }
}

export default Table;