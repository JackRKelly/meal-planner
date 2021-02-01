import { useRouter } from "next/dist/client/router";
import Layout from "../../components/Layout";
import { Content } from "../../components/Styled";

const ViewMeal = () => {
  const router = useRouter();
  const { id } = router.query;

  return (
    <Layout title="Meals | MealPlanner">
      <Content>
        <h1>Meal {id}</h1>
        <p>This is the about page</p>
      </Content>
    </Layout>
  );
};

export default ViewMeal;
