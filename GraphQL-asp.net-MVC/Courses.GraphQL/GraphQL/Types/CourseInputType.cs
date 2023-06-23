using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.GraphQL.Types
{
    public class CourseInputType:InputObjectGraphType
    {
        public CourseInputType()
        {
            Name = "CourseInputType";

            Field<StringGraphType>("Description");
            Field<StringGraphType>("Name");
            Field<ListGraphType<ReviewType>>("Reviews");
            Field<DateTimeGraphType>("DateAdded");
            Field<DateTimeGraphType>("DateUpdated");
        }
    }
}
