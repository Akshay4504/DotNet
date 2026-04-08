import React, { Component } from 'react';
 
class Person extends React.Component {
  constructor(props) {
    super(props);
 
    this.state = {
      personGoing: true,
      numberOfPersons: 5,
      leader: "",
      showForm: true,
      dob: ""
    };
 
    this.handleInputChange = this.handleInputChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }
 
  handleInputChange(event) {
    const target = event.target;
    const value =
      target.type === 'checkbox' ? target.checked : target.value;
    const name = target.name;
 
    this.setState({
      [name]: value
    });
  }
 
  handleSubmit = (event) => {
    event.preventDefault();
 
    this.setState({ showForm: false });
 
    console.log(this.state.showForm);
    console.log(this.state.personGoing);
 
    // if (this.state.personGoing) {
    //   alert('The number of persons: ' + this.state.numberOfPersons);
    // }
  };
 
  render() {
    return (
      <div>
        {this.state.showForm && (
          <form onSubmit={this.handleSubmit}>
            <label>
              Person Going:
              <input
                name="personGoing"
                type="checkbox"
                checked={this.state.personGoing}
                onChange={this.handleInputChange}
              />
            </label>
 
            <br />
 
            <label>
              Number of Persons:
              <input
                name="numberOfPersons"
                type="number"
                value={this.state.numberOfPersons}
                onChange={this.handleInputChange}
              />
            </label>
 
            <br />
 
            <label>
              Leader:
              <input
                name="leader"
                type="text"
                value={this.state.leader}
                onChange={this.handleInputChange}
              />
            </label>
 
            <br />
 
            <label>
              DOB:
              <input
                name="dob"
                type="date"
                value={this.state.dob}
                onChange={this.handleInputChange}
              />
            </label>
 
            <br />
 
            <button type="submit">Submit</button>
          </form>
        )}
      </div>
    );
  }
}
 
export default Person;