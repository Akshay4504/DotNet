//import "./styles.css";
import { useState, useEffect } from "react";
 
export default function ValidatingForms() {
  const [inputFields, setInputFields] = useState({
    email: "",
    password: "",
    age: null
  });
 
  const [errors, setErrors] = useState({});
  const [submitting, setSubmitting] = useState(false);
 
  const validateValues = (inputValues) => {
    let errors = {};
 
    if (inputValues.email.length < 15) {
      errors.email = "Email is too short";
    }
 
    if (inputValues.password.length < 5) {
      errors.password = "Password is too short";
    }
 
    if (!inputValues.age || inputValues.age < 18) {
      errors.age = "Minimum age is 18";
    }
 
    return errors;
  };
 
  const handleChange = (e) => {
    setInputFields({
      ...inputFields,
      [e.target.name]: e.target.value
    });
  };
 
  const handleSubmit = (event) => {
    event.preventDefault();
    setErrors(validateValues(inputFields));
    setSubmitting(true);
  };
 
  useEffect(() => {
    if (Object.keys(errors).length === 0 && submitting) {
      console.log("Form submitted successfully");
    }
  }, [errors]);
 
  return (
    <form onSubmit={handleSubmit}>
      <div>
        <label>Email</label>
        <input
          type="text"
          name="email"
          value={inputFields.email}
          onChange={handleChange}
        />
        {errors.email && <p>{errors.email}</p>}
      </div>
 
      <div>
        <label>Password</label>
        <input
          type="password"
          name="password"
          value={inputFields.password}
          onChange={handleChange}
        />
        {errors.password && <p>{errors.password}</p>}
      </div>
 
      <div>
        <label>Age</label>
        <input
          type="number"
          name="age"
          value={inputFields.age || ""}
          onChange={handleChange}
        />
        {errors.age && <p>{errors.age}</p>}
      </div>
 
      <button type="submit">Submit</button>
    </form>
  );
}