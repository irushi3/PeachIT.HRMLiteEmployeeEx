import React from 'react';
import axios from 'axios';
import '../Employee/AddEmployee.css'
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';
class AddEmployee extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            Name: '',
            Address: ''
        }
    }
    AddEmployee = () => {
        /* axios.post('https://localhost:44378/api/Employee/AddEmployee', {*/
        axios.post('https://localhost:5001/api/employee/addemployee', {
            Name: this.state.Name, Address: this.state.Address
        })
            .then(json => {
                
                if (json.status === 200) {
                    console.log(json.data.Status);
                    alert("Data Saved Successfully");
                    this.props.history.push('/EmployeeList')
                }
                else {
                    alert('Data not Saved');
                    debugger;
                    this.props.history.push('/EmployeeList')
                }
            })
    }

    handleChange = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }

    render() {
        return (
            <Container className="App">
                <h4 className="PageHeading">Enter Employee Information</h4>
                <Form className="form">
                    <Col>
                        <FormGroup row>
                            <Label for="name" sm={2}>Name</Label>
                            <Col sm={10}>
                                <Input type="text" name="Name" onChange={this.handleChange} value={this.state.Name} placeholder="Enter Name" />
                            </Col>
                        </FormGroup>

                        <FormGroup row>
                            <Label for="Password" sm={2}>Address</Label>
                            <Col sm={10}>
                                <Input type="text" name="Address" onChange={this.handleChange} value={this.state.Address} placeholder="Enter Address" />
                            </Col>
                        </FormGroup>
                    </Col>
                    <Col>
                        <FormGroup row>
                            <Col sm={10}>
                            </Col>
                            <Col sm={1}>
                                <button type="button" onClick={this.AddEmployee} className="btn btn-success">Submit</button>
                            </Col>
                            <Col sm={1}>
                                <Button color="danger">Cancel</Button>{' '}
                            </Col>
                            <Col sm={10}>
                            </Col>
                        </FormGroup>
                    </Col>
                </Form>
            </Container>
        );
    }

}

export default AddEmployee;