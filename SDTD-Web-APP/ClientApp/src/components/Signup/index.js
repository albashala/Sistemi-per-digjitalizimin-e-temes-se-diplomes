import React, {useState} from 'react';
import { 
  Container,
  FormInput, 
  FormLabel, 
  FormDropdown,
  FormWrap, 
  FormContent,
  Form,
  FormH1,
  FormButton,
  Text,
  Icon } from "./SignupElements";
  import { Redirect } from 'react-router'

const SignUp = () => {
  const [isStudent, setSelected] = useState("Student");
  const goStudentProfile = () => history.push('studentProfile');

  const handleSubmit = event => {
    event.preventDefault();

    if(isStudent == "Student"){
      fetch("https://localhost:44372/api/students",{
        method:'POST',
        headers:{
            'Accept':'application/json',
            'Content-Type':'application/json'
        },
        body:JSON.stringify({
            Emri:event.target.Name.value,
            Mbiemri:event.target.Surname.value,
            Email:event.target.Email.value,
            Password:event.target.Password.value,
            Departamenti:event.target.Department.value,
            DOB:event.target.DOB.value,
            IsActive:true,
            Thesis:null,
            Consultations:null,
            ProfessorId:null,
            Professor:null
        })
    })
    .then(response =>{
      return <Redirect to="/studentProfile" push={true} />
      //console.log('Submitted successfully')
    })
    .catch(error => console.log('Form submit error', error))
    }

    else if(isStudent == "Professor"){
      fetch("https://localhost:44372/api/professors",{
          method:'POST',
          headers:{
              'Accept':'application/json',
              'Content-Type':'application/json'
          },
          body:JSON.stringify({
              Emri:event.target.Name.value,
              Mbiemri:event.target.Surname.value,
              Email:event.target.Email.value,
              Password:event.target.Password.value,
              DOB:event.target.DOB.value,
              Titulli:event.target.Title.value,
              IsAvailable:true,
              Consultations:null,
              Students:null
          })
      })
      .then(response => console.log('Submitted successfully'))
      .catch(error => console.log('Form submit error', error))
    }
}

  return (
      <>
        <Container>
          <FormWrap>
            <Icon to="/"><img src={require('../Navbar/ubtlogo.png')} style={{width:"4%"}}/></Icon>
            <FormContent>
              <Form onSubmit={handleSubmit}>
                <FormH1>Create Account</FormH1>
                <FormLabel htmlFor='for'>Role</FormLabel>
                <FormDropdown type="role" onChange={e=>setSelected(e.target.value)} required>
                  <option value="Student">Student</option>
                  <option value="Professor">Professor</option>
                </FormDropdown>
                <FormLabel htmlFor='for'>Name</FormLabel>
                <FormInput type="name" name="Name"  required/>
                <FormLabel htmlFor='for'>Surname</FormLabel>
                <FormInput type="surname" name="Surname" required/>
                <FormLabel htmlFor='for'>Email</FormLabel>
                <FormInput type="email" name="Email" required/>
                <FormLabel htmlFor='for'>Password</FormLabel>
                <FormInput type="password" name="Password" required/>

                {isStudent == "Student" && <>
                <FormLabel htmlFor='for'>Department</FormLabel>
                <FormInput type="name" name="Department" required/></>}

                {isStudent == "Professor" && <>
                <FormLabel htmlFor='for'>Title</FormLabel>
                <FormInput type="name" name="Title" required/></>}
                
                <FormLabel htmlFor='for'>Date of Birth</FormLabel>
                <FormInput type="date" name="DOB" required/>
                <FormButton type='submit'>Sign up</FormButton>
              </Form>
            </FormContent>
          </FormWrap>
        </Container>
      </>
  );
};



export default SignUp;
