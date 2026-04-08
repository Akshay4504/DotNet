import React,{Component} from 'react';

class WelcomeInClass extends Component{
    render()
    {
        return(
            <div>
                <h1>Welcome to the ,{this.props.myname}</h1>
            </div>
        );
    }
}

export default WelcomeInClass