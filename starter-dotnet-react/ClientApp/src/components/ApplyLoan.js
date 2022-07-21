import react from 'react';
import React, {Compnent, useState} from react;
import {Button,Form,FormGroup,Input,Label} from 'reactstrap';

function ApplyLoan(){

    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [ssn,setSSN] = useState('');
    const [email, setEmail] = useState('');
    const [creditScore, setCreditScore] = useState('');
    const [status, setStatus] = useState('');
    const [loading, setLoading] = useState('');
    const [message, setMessage] = useState('');


    const submitApplication = e => {
        const response = await fetch('apply');
        const data = await response.json();
        setStatus(data);
    }
    return (
        <div>

        </div>
    )
}
export default ApplyLoan;