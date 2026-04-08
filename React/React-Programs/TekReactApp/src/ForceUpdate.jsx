import React,{Component} from 'react';

class ForceUpdateApp extends React.Component{
    constructor(){
        super();
        this.forcedUpdateState=this.forcedUpdateState.bind(this);
    }
    forceUpdateState(){
        console.log("ForcedupdateState called")
        this.forceUpdate();
    };
    render(){
        return(
            <div>
                <h1>Example to generate random number</h1>
                <h3>Random number: {Math.random()}</h3>
                <button onClick={this.forceUpdateState}>ForceUpdate</button>
            </div>
        )
    }
}