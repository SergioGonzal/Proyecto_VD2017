package WarlockSoft;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author S;G
 */
@WebService(serviceName = "EliminarConocimiento")
public class EliminarConocimiento {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "EliminarConocimientoUsuario")
    public boolean EliminarConocimientoUsuario(@WebParam(name = "IDConocimiento") String IDConocimiento, @WebParam(name = "IDUsuario") String IDUsuario) throws SQLException {
        //TODO write your implementation code here:
        boolean respuesta = false;
        Connection cx = Conexion.getConexion();
        
        try {
            PreparedStatement ps = cx.prepareStatement("Delete From CONOCIMIENTO_USUARIO Where ID_Conocimiento = ? AND ID_Usuario = ?");
            ps.setString(1, IDConocimiento);
            ps.setString(2, IDUsuario);
            
            int res = ps.executeUpdate();
            
            if(res>0){
                respuesta = true;
            }
            
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
            System.out.println("Error!");
        } finally {
            cx.close();
            System.out.println("Conexion Cerrada!");
        }
        return respuesta;
    }
}
