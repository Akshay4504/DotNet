import React,{Component} from 'react'

class ExpenseEntryitem extends React.Component{
    constructor(props){
        super(props);
    }
    render(){
        return(
            <div>
                <h2>This is a displaying props</h2>
                <div><b>Item:</b><em>{this.props.itemname}</em></div>
                <div><b>Amount:</b><em>{this.props.amount}</em></div>
                <div><b>Spend Date:</b><em>{this.props.spendDate.toString}</em></div>
                <div><b>category:</b><em>{this.props.category}</em></div>
            </div>
        );
    }
}
ExpenseEntryitem.defaultProps={
    itemname:"Grape Juice",
    amount:30.00,
    spendDate:new Date("2020-10-10"),
    category:"Food"
}

export default ExpenseEntryitem;