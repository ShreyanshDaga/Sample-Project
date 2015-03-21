﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIR.WinClient.ReservationServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReservationServiceRef.IReservationService")]
    public interface IReservationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewAdmin", ReplyAction="http://tempuri.org/IReservationService/CreateNewAdminResponse")]
        AIR.Entities.APIResult CreateNewAdmin(AIR.Entities.Admin newAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewAdmin", ReplyAction="http://tempuri.org/IReservationService/CreateNewAdminResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewAdminAsync(AIR.Entities.Admin newAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AdminLogin", ReplyAction="http://tempuri.org/IReservationService/AdminLoginResponse")]
        AIR.Entities.APIResult AdminLogin(string adminUserName, string adminPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AdminLogin", ReplyAction="http://tempuri.org/IReservationService/AdminLoginResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> AdminLoginAsync(string adminUserName, string adminPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AdminLogout", ReplyAction="http://tempuri.org/IReservationService/AdminLogoutResponse")]
        AIR.Entities.APIResult AdminLogout(int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AdminLogout", ReplyAction="http://tempuri.org/IReservationService/AdminLogoutResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> AdminLogoutAsync(int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UpdateAdmin", ReplyAction="http://tempuri.org/IReservationService/UpdateAdminResponse")]
        AIR.Entities.APIResult UpdateAdmin([System.ServiceModel.MessageParameterAttribute(Name="updateAdmin")] AIR.Entities.Admin updateAdmin1, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UpdateAdmin", ReplyAction="http://tempuri.org/IReservationService/UpdateAdminResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> UpdateAdminAsync(AIR.Entities.Admin updateAdmin, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAdminByUserName", ReplyAction="http://tempuri.org/IReservationService/GetAdminByUserNameResponse")]
        AIR.Entities.Admin GetAdminByUserName(string adminUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAdminByUserName", ReplyAction="http://tempuri.org/IReservationService/GetAdminByUserNameResponse")]
        System.Threading.Tasks.Task<AIR.Entities.Admin> GetAdminByUserNameAsync(string adminUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetLoggedInAdmin", ReplyAction="http://tempuri.org/IReservationService/GetLoggedInAdminResponse")]
        AIR.Entities.Admin GetLoggedInAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetLoggedInAdmin", ReplyAction="http://tempuri.org/IReservationService/GetLoggedInAdminResponse")]
        System.Threading.Tasks.Task<AIR.Entities.Admin> GetLoggedInAdminAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewUser", ReplyAction="http://tempuri.org/IReservationService/CreateNewUserResponse")]
        AIR.Entities.APIResult CreateNewUser(AIR.Entities.User newUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewUser", ReplyAction="http://tempuri.org/IReservationService/CreateNewUserResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewUserAsync(AIR.Entities.User newUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UserLogin", ReplyAction="http://tempuri.org/IReservationService/UserLoginResponse")]
        AIR.Entities.APIResult UserLogin(string userName, string userPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UserLogin", ReplyAction="http://tempuri.org/IReservationService/UserLoginResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> UserLoginAsync(string userName, string userPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UserLogout", ReplyAction="http://tempuri.org/IReservationService/UserLogoutResponse")]
        AIR.Entities.APIResult UserLogout(int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UserLogout", ReplyAction="http://tempuri.org/IReservationService/UserLogoutResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> UserLogoutAsync(int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UpdateUser", ReplyAction="http://tempuri.org/IReservationService/UpdateUserResponse")]
        AIR.Entities.APIResult UpdateUser([System.ServiceModel.MessageParameterAttribute(Name="updateUser")] AIR.Entities.User updateUser1, int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/UpdateUser", ReplyAction="http://tempuri.org/IReservationService/UpdateUserResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> UpdateUserAsync(AIR.Entities.User updateUser, int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetUserByUserName", ReplyAction="http://tempuri.org/IReservationService/GetUserByUserNameResponse")]
        AIR.Entities.User GetUserByUserName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetUserByUserName", ReplyAction="http://tempuri.org/IReservationService/GetUserByUserNameResponse")]
        System.Threading.Tasks.Task<AIR.Entities.User> GetUserByUserNameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetLoggedInUser", ReplyAction="http://tempuri.org/IReservationService/GetLoggedInUserResponse")]
        AIR.Entities.User GetLoggedInUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetLoggedInUser", ReplyAction="http://tempuri.org/IReservationService/GetLoggedInUserResponse")]
        System.Threading.Tasks.Task<AIR.Entities.User> GetLoggedInUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewAircraft", ReplyAction="http://tempuri.org/IReservationService/CreateNewAircraftResponse")]
        AIR.Entities.APIResult CreateNewAircraft(AIR.Entities.Aircraft newAircraft, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewAircraft", ReplyAction="http://tempuri.org/IReservationService/CreateNewAircraftResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewAircraftAsync(AIR.Entities.Aircraft newAircraft, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/RemoveAircraft", ReplyAction="http://tempuri.org/IReservationService/RemoveAircraftResponse")]
        AIR.Entities.APIResult RemoveAircraft(int iAircraftId, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/RemoveAircraft", ReplyAction="http://tempuri.org/IReservationService/RemoveAircraftResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> RemoveAircraftAsync(int iAircraftId, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAircraftDetails", ReplyAction="http://tempuri.org/IReservationService/GetAircraftDetailsResponse")]
        AIR.Entities.Aircraft GetAircraftDetails(int iAircraft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAircraftDetails", ReplyAction="http://tempuri.org/IReservationService/GetAircraftDetailsResponse")]
        System.Threading.Tasks.Task<AIR.Entities.Aircraft> GetAircraftDetailsAsync(int iAircraft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllAircrafts", ReplyAction="http://tempuri.org/IReservationService/GetAllAircraftsResponse")]
        System.Collections.Generic.List<AIR.Entities.Aircraft> GetAllAircrafts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllAircrafts", ReplyAction="http://tempuri.org/IReservationService/GetAllAircraftsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Aircraft>> GetAllAircraftsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewFlight", ReplyAction="http://tempuri.org/IReservationService/CreateNewFlightResponse")]
        AIR.Entities.APIResult CreateNewFlight(AIR.Entities.Flight newFlight, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CreateNewFlight", ReplyAction="http://tempuri.org/IReservationService/CreateNewFlightResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewFlightAsync(AIR.Entities.Flight newFlight, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/RemoveFlight", ReplyAction="http://tempuri.org/IReservationService/RemoveFlightResponse")]
        AIR.Entities.APIResult RemoveFlight(int iFlightId, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/RemoveFlight", ReplyAction="http://tempuri.org/IReservationService/RemoveFlightResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> RemoveFlightAsync(int iFlightId, int iAdminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetFlightDetails", ReplyAction="http://tempuri.org/IReservationService/GetFlightDetailsResponse")]
        AIR.Entities.Flight GetFlightDetails(int iFlightId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetFlightDetails", ReplyAction="http://tempuri.org/IReservationService/GetFlightDetailsResponse")]
        System.Threading.Tasks.Task<AIR.Entities.Flight> GetFlightDetailsAsync(int iFlightId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllFlights", ReplyAction="http://tempuri.org/IReservationService/GetAllFlightsResponse")]
        System.Collections.Generic.List<AIR.Entities.Flight> GetAllFlights();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllFlights", ReplyAction="http://tempuri.org/IReservationService/GetAllFlightsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Flight>> GetAllFlightsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AddNewBooking", ReplyAction="http://tempuri.org/IReservationService/AddNewBookingResponse")]
        AIR.Entities.APIResult AddNewBooking(AIR.Entities.Booking newBooking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/AddNewBooking", ReplyAction="http://tempuri.org/IReservationService/AddNewBookingResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> AddNewBookingAsync(AIR.Entities.Booking newBooking);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/ChangeBooking", ReplyAction="http://tempuri.org/IReservationService/ChangeBookingResponse")]
        AIR.Entities.APIResult ChangeBooking(AIR.Entities.Booking booking, int iBookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/ChangeBooking", ReplyAction="http://tempuri.org/IReservationService/ChangeBookingResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> ChangeBookingAsync(AIR.Entities.Booking booking, int iBookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CancelBooking", ReplyAction="http://tempuri.org/IReservationService/CancelBookingResponse")]
        AIR.Entities.APIResult CancelBooking(int iBookingId, int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/CancelBooking", ReplyAction="http://tempuri.org/IReservationService/CancelBookingResponse")]
        System.Threading.Tasks.Task<AIR.Entities.APIResult> CancelBookingAsync(int iBookingId, int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetBookingDetails", ReplyAction="http://tempuri.org/IReservationService/GetBookingDetailsResponse")]
        AIR.Entities.Booking GetBookingDetails(int iBookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetBookingDetails", ReplyAction="http://tempuri.org/IReservationService/GetBookingDetailsResponse")]
        System.Threading.Tasks.Task<AIR.Entities.Booking> GetBookingDetailsAsync(int iBookingId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllBookingsForUser", ReplyAction="http://tempuri.org/IReservationService/GetAllBookingsForUserResponse")]
        System.Collections.Generic.List<AIR.Entities.Booking> GetAllBookingsForUser(int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllBookingsForUser", ReplyAction="http://tempuri.org/IReservationService/GetAllBookingsForUserResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Booking>> GetAllBookingsForUserAsync(int iUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllBookingsForFlight", ReplyAction="http://tempuri.org/IReservationService/GetAllBookingsForFlightResponse")]
        System.Collections.Generic.List<AIR.Entities.Booking> GetAllBookingsForFlight(int iFlightId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationService/GetAllBookingsForFlight", ReplyAction="http://tempuri.org/IReservationService/GetAllBookingsForFlightResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Booking>> GetAllBookingsForFlightAsync(int iFlightId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservationServiceChannel : global::AIR.WinClient.ReservationServiceRef.IReservationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservationServiceClient : System.ServiceModel.ClientBase<global::AIR.WinClient.ReservationServiceRef.IReservationService>, global::AIR.WinClient.ReservationServiceRef.IReservationService {
        
        public ReservationServiceClient() {
        }
        
        public ReservationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AIR.Entities.APIResult CreateNewAdmin(AIR.Entities.Admin newAdmin) {
            return base.Channel.CreateNewAdmin(newAdmin);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewAdminAsync(AIR.Entities.Admin newAdmin) {
            return base.Channel.CreateNewAdminAsync(newAdmin);
        }
        
        public AIR.Entities.APIResult AdminLogin(string adminUserName, string adminPassword) {
            return base.Channel.AdminLogin(adminUserName, adminPassword);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> AdminLoginAsync(string adminUserName, string adminPassword) {
            return base.Channel.AdminLoginAsync(adminUserName, adminPassword);
        }
        
        public AIR.Entities.APIResult AdminLogout(int iAdminId) {
            return base.Channel.AdminLogout(iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> AdminLogoutAsync(int iAdminId) {
            return base.Channel.AdminLogoutAsync(iAdminId);
        }
        
        public AIR.Entities.APIResult UpdateAdmin(AIR.Entities.Admin updateAdmin1, int iAdminId) {
            return base.Channel.UpdateAdmin(updateAdmin1, iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> UpdateAdminAsync(AIR.Entities.Admin updateAdmin, int iAdminId) {
            return base.Channel.UpdateAdminAsync(updateAdmin, iAdminId);
        }
        
        public AIR.Entities.Admin GetAdminByUserName(string adminUserName) {
            return base.Channel.GetAdminByUserName(adminUserName);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.Admin> GetAdminByUserNameAsync(string adminUserName) {
            return base.Channel.GetAdminByUserNameAsync(adminUserName);
        }
        
        public AIR.Entities.Admin GetLoggedInAdmin() {
            return base.Channel.GetLoggedInAdmin();
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.Admin> GetLoggedInAdminAsync() {
            return base.Channel.GetLoggedInAdminAsync();
        }
        
        public AIR.Entities.APIResult CreateNewUser(AIR.Entities.User newUser) {
            return base.Channel.CreateNewUser(newUser);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewUserAsync(AIR.Entities.User newUser) {
            return base.Channel.CreateNewUserAsync(newUser);
        }
        
        public AIR.Entities.APIResult UserLogin(string userName, string userPassword) {
            return base.Channel.UserLogin(userName, userPassword);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> UserLoginAsync(string userName, string userPassword) {
            return base.Channel.UserLoginAsync(userName, userPassword);
        }
        
        public AIR.Entities.APIResult UserLogout(int iUserId) {
            return base.Channel.UserLogout(iUserId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> UserLogoutAsync(int iUserId) {
            return base.Channel.UserLogoutAsync(iUserId);
        }
        
        public AIR.Entities.APIResult UpdateUser(AIR.Entities.User updateUser1, int iUserId) {
            return base.Channel.UpdateUser(updateUser1, iUserId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> UpdateUserAsync(AIR.Entities.User updateUser, int iUserId) {
            return base.Channel.UpdateUserAsync(updateUser, iUserId);
        }
        
        public AIR.Entities.User GetUserByUserName(string userName) {
            return base.Channel.GetUserByUserName(userName);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.User> GetUserByUserNameAsync(string userName) {
            return base.Channel.GetUserByUserNameAsync(userName);
        }
        
        public AIR.Entities.User GetLoggedInUser() {
            return base.Channel.GetLoggedInUser();
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.User> GetLoggedInUserAsync() {
            return base.Channel.GetLoggedInUserAsync();
        }
        
        public AIR.Entities.APIResult CreateNewAircraft(AIR.Entities.Aircraft newAircraft, int iAdminId) {
            return base.Channel.CreateNewAircraft(newAircraft, iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewAircraftAsync(AIR.Entities.Aircraft newAircraft, int iAdminId) {
            return base.Channel.CreateNewAircraftAsync(newAircraft, iAdminId);
        }
        
        public AIR.Entities.APIResult RemoveAircraft(int iAircraftId, int iAdminId) {
            return base.Channel.RemoveAircraft(iAircraftId, iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> RemoveAircraftAsync(int iAircraftId, int iAdminId) {
            return base.Channel.RemoveAircraftAsync(iAircraftId, iAdminId);
        }
        
        public AIR.Entities.Aircraft GetAircraftDetails(int iAircraft) {
            return base.Channel.GetAircraftDetails(iAircraft);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.Aircraft> GetAircraftDetailsAsync(int iAircraft) {
            return base.Channel.GetAircraftDetailsAsync(iAircraft);
        }
        
        public System.Collections.Generic.List<AIR.Entities.Aircraft> GetAllAircrafts() {
            return base.Channel.GetAllAircrafts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Aircraft>> GetAllAircraftsAsync() {
            return base.Channel.GetAllAircraftsAsync();
        }
        
        public AIR.Entities.APIResult CreateNewFlight(AIR.Entities.Flight newFlight, int iAdminId) {
            return base.Channel.CreateNewFlight(newFlight, iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> CreateNewFlightAsync(AIR.Entities.Flight newFlight, int iAdminId) {
            return base.Channel.CreateNewFlightAsync(newFlight, iAdminId);
        }
        
        public AIR.Entities.APIResult RemoveFlight(int iFlightId, int iAdminId) {
            return base.Channel.RemoveFlight(iFlightId, iAdminId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> RemoveFlightAsync(int iFlightId, int iAdminId) {
            return base.Channel.RemoveFlightAsync(iFlightId, iAdminId);
        }
        
        public AIR.Entities.Flight GetFlightDetails(int iFlightId) {
            return base.Channel.GetFlightDetails(iFlightId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.Flight> GetFlightDetailsAsync(int iFlightId) {
            return base.Channel.GetFlightDetailsAsync(iFlightId);
        }
        
        public System.Collections.Generic.List<AIR.Entities.Flight> GetAllFlights() {
            return base.Channel.GetAllFlights();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Flight>> GetAllFlightsAsync() {
            return base.Channel.GetAllFlightsAsync();
        }
        
        public AIR.Entities.APIResult AddNewBooking(AIR.Entities.Booking newBooking) {
            return base.Channel.AddNewBooking(newBooking);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> AddNewBookingAsync(AIR.Entities.Booking newBooking) {
            return base.Channel.AddNewBookingAsync(newBooking);
        }
        
        public AIR.Entities.APIResult ChangeBooking(AIR.Entities.Booking booking, int iBookingId) {
            return base.Channel.ChangeBooking(booking, iBookingId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> ChangeBookingAsync(AIR.Entities.Booking booking, int iBookingId) {
            return base.Channel.ChangeBookingAsync(booking, iBookingId);
        }
        
        public AIR.Entities.APIResult CancelBooking(int iBookingId, int iUserId) {
            return base.Channel.CancelBooking(iBookingId, iUserId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.APIResult> CancelBookingAsync(int iBookingId, int iUserId) {
            return base.Channel.CancelBookingAsync(iBookingId, iUserId);
        }
        
        public AIR.Entities.Booking GetBookingDetails(int iBookingId) {
            return base.Channel.GetBookingDetails(iBookingId);
        }
        
        public System.Threading.Tasks.Task<AIR.Entities.Booking> GetBookingDetailsAsync(int iBookingId) {
            return base.Channel.GetBookingDetailsAsync(iBookingId);
        }
        
        public System.Collections.Generic.List<AIR.Entities.Booking> GetAllBookingsForUser(int iUserId) {
            return base.Channel.GetAllBookingsForUser(iUserId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Booking>> GetAllBookingsForUserAsync(int iUserId) {
            return base.Channel.GetAllBookingsForUserAsync(iUserId);
        }
        
        public System.Collections.Generic.List<AIR.Entities.Booking> GetAllBookingsForFlight(int iFlightId) {
            return base.Channel.GetAllBookingsForFlight(iFlightId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AIR.Entities.Booking>> GetAllBookingsForFlightAsync(int iFlightId) {
            return base.Channel.GetAllBookingsForFlightAsync(iFlightId);
        }
    }
}
