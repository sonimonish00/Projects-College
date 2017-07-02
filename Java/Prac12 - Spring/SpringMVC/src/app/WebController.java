package app;

import javax.servlet.http.HttpServletRequest;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

@Controller
@RequestMapping("/")
public class WebController {

	@RequestMapping(method = RequestMethod.GET)
	   
	public String welcomePage(Model model) {
			return "WelcomePage";
	}
	
	@RequestMapping(value="Login",method = RequestMethod.POST)
	   public String addPage1(Model model,HttpServletRequest request) {
			
		
			if(request.getParameter("username").equals("deep") && request.getParameter("password").equals("123"))
			{
				return "Success";
			}
			
			return "redirect:/";
	}
}
