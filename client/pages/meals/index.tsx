import { useEffect, useState } from "react";
import Layout from "../../components/Layout";
import { Content } from "../../components/Styled";
import { Meal } from "../../interfaces";

const Meals = () => {
  const [meals, setMeals] = useState<Meal[]>([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/meals/").then((data) =>
      data.json().then((json: Meal[]) => console.log(json))
    );
  }, []);

  return (
    <Layout title="Meals | MealPlanner">
      <Content>
        <h1>Meals</h1>
        <p>This is the about page</p>
      </Content>
    </Layout>
  );
};

export default Meals;
