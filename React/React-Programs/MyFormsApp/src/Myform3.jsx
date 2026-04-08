import React, { useState } from "react";
 
export default function FuncControlledForm() {
  const [name, setName] = useState("");
  const [age, setAge] = useState("");
  const [inputError, setInputError] = useState(null);
 
  const handleSubmit = (event) => {
    event.preventDefault();
 
    if (name) {
      alert(`The name you entered was: ${name}, and Age: ${age}`);
    }
 
    // Continue further processing as required
    // perform validation as required
    // pass the data via an API to a DB ...
    // Navigate to the next page/component
  };
 
  function handleNameChange(event) {
    const value = event.target.value;
    setName(value);
 
    if (value.length < 5) {
      setInputError("Input must be at least 5 characters");
    } else {
      setInputError(null);
    }
  }

 
  function handleAgeChange(event) {
    setAge(event.target.value);
  }
 
  return (
    <form onSubmit={handleSubmit}>
      <div>
        <label>Name: </label>
        <input type="text" value={name} onChange={handleNameChange} />
        {inputError && <p style={{ color: "red" }}>{inputError}</p>}
      </div>
 
      <div>
        <label>Age: </label>
        <input type="number" value={age} onChange={handleAgeChange} />
      </div>
 
      <button type="submit">Submit</button>
    </form>
  );
}