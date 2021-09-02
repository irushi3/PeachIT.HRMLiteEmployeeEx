import React, { Component } from 'react';
import axios from 'axios';
import Table from './Table';

export default class EmployeeList extends Component {

    constructor(props) {
        super(props);
        this.state = { business: [], deleted: false };
        
    }
    componentDidMount() {
       /* axios.get('https://localhost:44378/api/Employee/GetEmployees')*/
        axios.get(' https://localhost:5001/api/employee/getemployees')
            .then(response => {
                this.setState({ business: response.data });
               /* console.log(this.state.business)*/
                /*debugger;*/

            })
            .catch(function (error) {
                console.log(error);
            })
    }

    componentDidUpdate() {
        if (this.state.deleted) {
            axios.get(' https://localhost:5001/api/employee/getemployees')
                .then(response => {
                    this.setState({ business: response.data, deleted: false });
                    /* console.log(this.state.business)*/
                    /*debugger;*/

                })
                .catch(function (error) {
                    console.log(error);
                })
        }
    }

    DeleteEmployee = (empId) => {
        /*axios.delete('https://localhost:44378/api/Employee/DeleteEmployee?id=' + this.props.obj.Id)*/
        axios.delete('https://localhost:5001/api/employee/deleteemployee?Id=' + empId)
            .then(json => {
                if (json.status === 200) {
                    alert('Record deleted successfully!!');
                    this.setState({ deleted: true })


                    
                }
            })
    }

    tabRow() {
        /*return this.state.business.map(function (object, i) {
            return <Table obj={object} key={i} />;
        });*/
        const rows = this.state.business.map((row, i) => {
            return <Table obj={row} key={i} del={this.DeleteEmployee} />;

        })

        return rows;
    }

    render() {
        return (
            <div>
                <h4 align="center">Employee List</h4>
                <table className="table table-striped" style={{ marginTop: 10 }}>
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Address</th>
                            <th colSpan="4">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.tabRow()}
                    </tbody>
                </table>
            </div>
        );
    }
}