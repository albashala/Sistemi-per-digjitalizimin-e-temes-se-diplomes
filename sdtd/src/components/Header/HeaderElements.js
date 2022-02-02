import styled from 'styled-components'
import {MdKeyboardArrowRight, MdArrowForward} from 'react-icons/md'

export const HeaderContainer = styled.div`
     background: #f0f0f0;
     display: flex;
     justify-content: center;
     align-items: center;
     padding: 0 30px;
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
    height: 100%;
    overflow: hidden;
`;

export const VideoBg = styled.video`
    width:100%;
    height:100%;
    -o-object-fit: cover;
    object-fit:cover;
    background:#f0f0f0; 
`;

export const HeaderContent = styled.div`
    z-index: 3;
    max-width:2000px; 
    height:350px;
    padding : 8px 24px;
    background:rgba(255,255,255, 0.3);
    display: flex;
    position: absolute;
    flex-direction: column;
    align-items: center;
    justify-content: center;

    @media screen and (max-width: 768px){
        margin-top:-20%;
    }
    @media screen and (max-width: 480px){
        margin-top:-40%;
    }

`;

export const HeaderH1 = styled.h1`
    color:#244082 ;
    font-size: 48px;
    text-align: center;
    margin-top:30px;

@media screen and (max-width: 768px){
    font-size:40px;
}

@media screen and (max-width: 480px){
    font-size:32px;
}
`;

export const HeaderP = styled.p`
    margin-top: 24px;
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
    margin-top: 22px;
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
