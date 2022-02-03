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
  import { AuthService, useAuth } from "gatsby-theme-auth0";

const Signin = () => {
  const { isLoggedIn, profile } = useAuth();
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
                <FormButton type='submit' onClick={AuthService.login}>Sign in</FormButton>
                <Text>Forgot password</Text>
              </Form>
            </FormContent>
          </FormWrap>
        </Container>
      </>
  );
};

export default Signin;
