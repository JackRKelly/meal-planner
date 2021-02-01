import React from "react";
import Layout from "../components/Layout";
import {
  Content,
  Section,
  SectionHeader,
  SectionText,
} from "../components/Styled";

const IndexPage = () => (
  <Layout title="Home | Meal Planner">
    <Content>
      <Section>
        <SectionHeader>Meal Planner</SectionHeader>
        <SectionText>
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Sit iste,
          inventore dolor praesentium cum consectetur et esse doloremque commodi
          magnam aliquid, expedita provident a. Eligendi neque corrupti unde
          ducimus dicta. Minima rerum necessitatibus ad tempora magnam
          voluptatem quaerat exercitationem sapiente sit illo cum possimus et
          rem, consequuntur voluptatibus deleniti esse doloremque voluptates.
        </SectionText>
      </Section>
    </Content>
  </Layout>
);

export default IndexPage;
