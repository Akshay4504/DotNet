import React, { useState } from "react";
 
const BmiCalculator = () => {
  const [weight, setWeight] = useState("");
  const [height, setHeight] = useState("");
  const [bmi, setBmi] = useState("");
  const [status, setStatus] = useState("");
 
  const calculateBMI = () => {
    if (!weight || !height) {
      alert("Please enter both weight and height!");
      return;
    }
 
    const heightInMeters = parseFloat(height) / 100;
    const bmiValue = (
      parseFloat(weight) /
      (heightInMeters * heightInMeters)
    ).toFixed(2);
 
    setBmi(bmiValue);
 
    let bmiStatus = "";
 
    if (bmiValue < 18.5) {
      bmiStatus = "Underweight";
    } else if (bmiValue < 24.9) {
      bmiStatus = "Normal weight";
    } else if (bmiValue < 29.9) {
      bmiStatus = "Overweight";
    } else {
      bmiStatus = "Obese";
    }
 
    setStatus(bmiStatus);
  };
 
  return (
    <div>
      <h2>BMI Calculator</h2>
 
      <input
        type="number"
        placeholder="Enter weight (kg)"
        value={weight}
        onChange={(e) => setWeight(e.target.value)}
      />
 
      <br />
 
      <input
        type="number"
        placeholder="Enter height (cm)"
        value={height}
        onChange={(e) => setHeight(e.target.value)}
      />
 
      <br />
 
      <button onClick={calculateBMI}>Calculate BMI</button>
 
      {bmi && (
        <div>
          <h3>Your BMI: {bmi}</h3>
          <h4>Status: {status}</h4>
        </div>
      )}
    </div>
  );
};
 
export default BmiCalculator;
 