import React from "react";
 
export class UCForm1 extends React.Component {
  constructor(props) {
    super(props);
 
    this.updateSubmit = this.updateSubmit.bind(this);
 
    this.nameRef = React.createRef();
    this.companynameRef = React.createRef();
    this.dateofbirthRef = React.createRef();
  }
 
  updateSubmit(event) {
    event.preventDefault();
 
    const compname = this.companynameRef.current.value;
 
    alert(
      "You have entered the UserName and CompanyName successfully. Name: " +
        this.nameRef.current.value +
        " " +
        compname +
        " " +
        this.dateofbirthRef.current.value
    );
  }
 
  render() {
    return (
      <form onSubmit={this.updateSubmit}>
        <h1>Uncontrolled Form Example</h1>
 
        <label>
          Name:
          <input
            type="text"
            id="myName"
            defaultValue="Ginger"
            ref={this.nameRef}
          />
        </label>
 
        <br />
 
        <label>
          Company Name:
          <input
            type="text"
            id="compName"
            ref={this.companynameRef}
          />
        </label>
 
        <br />
 
        <label>
          Date of Birth:
          <input
            type="date"
            ref={this.dateofbirthRef}
          />
        </label>
 
        <br />
 
        <button type="submit">Submit</button>
      </form>
    );
  }
}
export default UCForm1