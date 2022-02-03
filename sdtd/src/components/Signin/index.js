import React from 'react';
import { 
  Container,
  FormInput, 
  FormLabel, 
  FormWrap, 
  FormContent,
  Form,
  FormH1,
  FormButton,
  Text,
  Icon } from "./SigninElements";

const Signin = () => {
  return (
      <>
        <Container>
          <FormWrap>
            <Icon to="/"><img src={require('../Navbar/ubtlogo.png')} style={{width:"4%"}}/></Icon>
            <FormContent>
              <Form action="#">
                <FormH1>Sign in to your account</FormH1>
                <FormLabel htmlFor='for'>Email</FormLabel>
                <FormInput type="email" required/>
                <FormLabel htmlFor='for'>Password</FormLabel>
                <FormInput type="password" required/>
                <FormButton type='submit'>Sign in</FormButton>
                <Text>Forgot password</Text>
              </Form>
            </FormContent>
          </FormWrap>
        </Container>
      </>
  );
};

export default Signin;
