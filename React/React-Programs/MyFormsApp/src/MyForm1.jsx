import React,{Component,useState,useRef} from 'react'

export default function Uncontrolled(){
    const selectOptionRef=useRef(null);
    const checkboxRef=useRef(null);
    const textboxRef=useRef(null);

    function handleSubmit(event){
        event.preventDefault();
        console.log("input value: ",textboxRef.current.value);
        console.log("selected value: ",selectOptionRef.current.value);
        console.log("CheckBox value: ",checkboxRef.current.value);
    }
    return(
        <form onSubmit={handleSubmit}>
        <label>
        <p>Name:</p>
        <input ref={textboxRef} type="text"/>
        </label>
        <label>
        <p>Favourie Colour</p>
        <select ref={selectOptionRef}>
        <option value="red">RED</option>
        <option value="blue">BLUE</option>
        <option value="orange">ORANGE</option>
        </select>
        </label>
        <br/>
        <label>
        Do You like react?
        <input ref={checkboxRef} typr="checkbox"></input>
        </label><br/>
        <button type="Submit">Submit</button>
        </form>
    
    );
}
