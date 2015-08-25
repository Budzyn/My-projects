   function Man()
        {
            this.name = "name";
            this.age = 0;
            this.live = function ()
            {
                return this.name + "; " + this.age + " лет";
            };
        }
        function Student()
        {
			this.education="education";
            this.study = function ()
            {
				return this.education;
            };
        }
        
        Student.prototype = new Man();
        var st = new Student();
        st.age = 20;
        st.name = "Вася";
		education="DPI";
        alert(st.live());
		alert(sr.study());
		function duckType(manIns)
        {
            if ("study" in manIns)
            {
                return "Student"
            }
            return "Man";
        }
