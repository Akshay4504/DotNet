import React from 'react';
import react,{Component} from 'react';

class MyCallRef extends react.Component{
    constructor(props){
        super(props);
        this.callRef=React.createRef();
        this.addingRefInput=this.addingRefInput.bind(this);
    }
    addingRefInput(){
        console.log(this.callRef.current.value)
        this.callRef.current.focus();
    }
    handleChange(){
        if(this.callRef.current.value!="James"){
            console.log("Invalid name");
            this.callRef.current.focus();
        }
    }
    render(){
        return (
            <div>
                <h1>Adding a Ref to DOM Element</h1>
                <input type="text" onChange={this.handleChange} ref={this.callRef}/>
                <input type="button" value="Add text Input" onClick={this.addingRefInput}/>
            </div>
        );
    }
}
export default MyCallRef