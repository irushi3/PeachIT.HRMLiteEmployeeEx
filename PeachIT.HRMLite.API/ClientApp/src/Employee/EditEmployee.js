import React from 'react';
import { Container, Col, Form, Row, FormGroup, Label, Input, Button } from 'reactstrap';
import axios from 'axios'
import '../Employee/AddEmployee.css'

class Edit extends React.Component {
    constructor(props) {
        super(props)

        this.onChangeName = this.onChangeName.bind(this);
        this.onChangeAddress = this.onChangeAddress.bind(this);
        this.onSubmit = this.onSubmit.bind(this);

        this.state = {
            Name: '',
            Address: ''

        }
    }

    componentDidMount() {
        /* axios.get('https://localhost:44378/api/Employee/GetEmployee?Id=' + this.props.match.params.id)*/
        axios.get('https://localhost:5001/api/employee/getemployee?Id=' + this.props.match.params.id)
            .then(response => {
                this.setState({
                    Name: response.data.name,
                    Address: response.data.address
                });

            })
            .catch(function (error) {
                console.log(error);
            })
    }

    onChangeName(e) {
        this.setState({
            Name: e.target.value
        });
    }

    onChangeAddress(e) {
        this.setState({
            Address: e.target.value
        });
    }

    onSubmit(e) {
       /* debugger;*/
        e.preventDefault();
        const obj = {
            Id: this.props.match.params.id,
            Name: this.state.Name,
            Address: this.state.Address

        };
        /*axios.post('https://localhost:44378/api/Employee/UpdateEmployee', obj)*/
        /*axios.post(' https://localhost:5001/api/employee/updateemployee', obj)*/
        console.log(obj)
        axios.put(' https://localhost:5001/api/employee/updateemployee/' , obj)
            .then(res => console.log(res.data));
        /* debugger;*/
        this.props.history.push('/EmployeeList')
    }
    render() {
        return (
            <Container className="App">

                <h4 className="PageHeading">Update Employee Information</h4>
                <Form className="form" onSubmit={this.onSubmit}>
                    <Col>
                        <FormGroup row>
                            <Label for="name" sm={2}>Name</Label>
                            <Col sm={10}>
                                <Input type="text" name="Name" value={this.state.Name} onChange={this.onChangeName}
                                    placeholder="Enter Name" />

                            </Col>
                        </FormGroup>

                        <FormGroup row>
                            <Label for="Password" sm={2}>Address</Label>
                            <Col sm={10}>
                                <Input type="text" name="Address" value={this.state.Address} onChange={this.onChangeAddress}
                                    placeholder="Enter Address" />
                            </Col>
                        </FormGroup>
                    </Col>
                    <Col>
                        <FormGroup row>
                            <Col sm={5}>
                            </Col>
                            <Col sm={1}>
                                <Button type="submit" color="success">Submit</Button>{' '}
                            </Col>
                            <Col sm={1}>
                                <Button color="danger">Cancel</Button>{' '}
                            </Col>
                            <Col sm={5}>
                            </Col>
                        </FormGroup>
                    </Col>
                </Form>
            </Container>
        );
    }

}

export default Edit;