import styled from "styled-components";
import { breakpoint } from "../util";

export const Content = styled.div`
  margin: auto;
  max-width: 1800px;
  margin: auto;
  width: 80%;
  @media (max-width: 800px) {
    width: 85%;
  }
  @media (max-width: 500px) {
    width: 90%;
  }
`;

export const SectionHeader = styled.h2`
  margin: 0 auto 0.5em;
  font-size: 3em;
  max-width: 1200px;
  text-align: center;
  line-height: 1;
  color: var(--black);
  @media (max-width: ${breakpoint.mobileL}) {
    font-size: 2em;
  }
`;

export const SectionText = styled.p`
  margin: 0 auto;
  font-size: 1.15em;
  max-width: 1200px;
  text-align: center;
  color: var(--gray);
`;

export const Section = styled.section`
  padding: 2em 0;
`;
