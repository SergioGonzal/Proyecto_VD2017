/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WarlockSoft;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author S;G
 */
@WebService(serviceName = "CrearTareaProyecto")
public class CrearTareaProyecto {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "GuardarTareaProyecto")
    public boolean GuardarTareaProyecto(@WebParam(name = "Nombre") String Nombre, @WebParam(name = "Descripcion") String Descripcion, @WebParam(name = "FechaInicio") String FechaInicio, @WebParam(name = "IDProyecto") String IDProyecto, @WebParam(name = "Conocimiento") String Conocimiento) throws SQLException {
        //TODO write your implementation code here:
        boolean respuesta = false;
        Connection cx = Conexion.getConexion();
        Connection cx1 = Conexion.getConexion();
        String IDc = "";
        
        try {
            PreparedStatement ps = cx.prepareStatement("Select ID_Conocimiento From CONOCIMIENTO Where Nombre_Conocimiento =?");
            ps.setString(1, Conocimiento);
            
            ResultSet res;
            res = ps.executeQuery();
            
            while (res.next()){
                IDc= res.getString("ID_Conocimiento");
            }
            
            //------------------------------------------------------------------
            PreparedStatement ps1 = cx1.prepareStatement("Insert Into TAREA(Nombre_Tarea, Descripcion, Fecha_Inicio, Estado, ID_Proyecto, ID_Conocimiento) Values(?,?,?,?,?,?)");
            ps1.setString(1, Nombre);
            ps1.setString(2, Descripcion);
            ps1.setString(3, FechaInicio);
            ps1.setString(4, "Activa");
            ps1.setString(5, IDProyecto);
            ps1.setString(6, IDc);
            
            int res1 = ps1.executeUpdate();
            
            if(res1>0){
                respuesta = true;
            }
            
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
            System.out.println("Error!");
        } finally {
            cx.close();
            cx1.close();
            System.out.println("Conexion Cerrada!");
        }
        return respuesta;
    }

    /**
     * Web service operation
     */
    @WebMethod(operationName = "ObtenerTareasProyecto")
    public String[] ObtenerTareasProyecto(@WebParam(name = "IDProyecto") String IDProyecto) throws SQLException {
        //TODO write your implementation code here:
        String[] Tareas = new String [100];
        int ContT = 0;
        Connection cx = Conexion.getConexion();
        
        try {
            PreparedStatement ps = cx.prepareStatement("Select Nombre_Tarea From Tarea Where ID_Proyecto =?");
            ps.setString(1, IDProyecto);
            
            ResultSet res;
            res = ps.executeQuery();
            
            while (res.next()){
                Tareas[ContT]= res.getString("Nombre_Tarea");
                ContT++;
            }
            
            
        } catch (SQLException ex) {
            System.out.println(ex.getMessage());
            System.out.println("Error!");
        } finally {
            cx.close();
            System.out.println("Conexion Cerrada!");
        }
        return Tareas;
    }
}