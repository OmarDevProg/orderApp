
import type { CodegenConfig } from '@graphql-codegen/cli';

const config: CodegenConfig = {
  overwrite: true,
  schema: "http://localhost:5048/graphql/",
  documents: "**/*.{gql,graphql}",
  generates: {
    'src/graphql/generated/schema.ts': {
      plugins: ['typescript', 'typescript-operations', 'typescript-react-apollo'],
      config:{

        withComponent:true
      }
    }
  }
};

export default config;
