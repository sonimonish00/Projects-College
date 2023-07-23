package application;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.cfg.Configuration;
import application.User;
public class Main {
public static void main(String[] args) {
		

		User user = new User();
		user.setId(1);
		user.setName("monish");
		user.setEnroll("soni");
		
		Address add = new Address();
		
		add.setCity("Mehsana");
		add.setPincode(38);
		add.setState("Gujarat");
		
		add.setUser(user);
		user.setAdd(add);
		
		Vehicle v1 = new Vehicle();
		v1.setVname("Hero Honda");
		v1.setVnumber("3880");
		
		Vehicle v2 = new Vehicle();
		v2.setVname("MARUTI SUZUKI");
		v2.setVnumber("6660");
		
		v1.setUser(user);
		v2.setUser(user);
		
			user.getVehicles().add(v1);
			user.getVehicles().add(v2);
			SessionFactory sf = new Configuration().configure().buildSessionFactory();
			Session session = sf.openSession();
			session.beginTransaction();
			session.save(user);
			session.save(add);
			session.save(v1);
			session.save(v2);
			session.getTransaction().commit();
			
			
			session.close();
			sf.close();

	}
}
