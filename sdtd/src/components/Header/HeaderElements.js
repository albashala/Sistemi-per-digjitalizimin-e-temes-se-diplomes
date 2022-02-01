import styled from 'styled-components'
import {MdKeyboardArrowRight, MdArrowForward} from 'react-icons/md'

export const HeaderContainer = styled.div`
     background: #f0f0f0;
     display: flex;
     justify-content: center;
     align-items: center;
     height: 800px;
     position: relative:
     z-index: 1;
`;

export const HeaderBg = styled.div`
    position: absolute;
    top:0;
    right:0;
    bottom:0;
    left:0 ;
    width: 100%;
    height: 100%;s
    overflow: hidden;
`

export const HeaderContent = styled.div`
    z-index: 3;
    max-width: 1200px;
    position: absolute:
    padding : 8px 24px;
    display: flex;
    flex-direction: column;
    align-items: center;
`

export const HeaderH1 = styled.h1`
    color:#244082 ;
    font-size: 48px;
    text-align: center;
    margin-top:250px;

@media screen and (max-width: 768px){
    font-size:40px;
}

@media screen and (max-width: 480px){
    font-size:32px;
}
`

export const HeaderP = styled.p`
    margin-top:50px;
    color: #244082;
    font-size: 24px;
    text-align: center;
    max-width: 600px;

    @media screen and (max-width: 768px){
        font-size:24px;
    }
    
    @media screen and (max-width: 480px){
        font-size: 18px;
    }
    `;
export const HeaderBtnWrapper = styled.div`
    margin-top: 32px;
    display: flex;
    flex-direction: column;
    align-items: center;

`;

export const ArrowForward = styled(MdArrowForward)`
    margin-left: 8px;
    font-size:20px;
`;
export const ArrowRight = styled(MdKeyboardArrowRight)`
    margin-left: 8px;
    font-size:20px;
`;
