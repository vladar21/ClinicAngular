﻿// <auto-generated />
using System;
using ClinicAngular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicAngular.Migrations
{
    [DbContext(typeof(ClinicAngularDbCcontext))]
    [Migration("20201128191547_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClinicAngular.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Apartment")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("apartment");

                    b.Property<string>("Country")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("country");

                    b.Property<string>("House")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("house");

                    b.Property<string>("Locality")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("locality");

                    b.Property<string>("Region")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("region");

                    b.Property<string>("Street")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("street");

                    b.Property<string>("ZipCode")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("zipcode");

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ClinicAngular.Models.Appointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsPatientVisited")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_patient_visited");

                    b.Property<int>("PatientID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("patient_id");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("schedule_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ClinicAngular.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("AddressID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("address_id");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp")
                        .HasColumnName("birthday");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("timestamp")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("timestamp")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasColumnType("timestamp")
                        .HasColumnName("middle_name");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ClinicAngular.Models.Doc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ContactID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("contact_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("HiredAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("hired_at");

                    b.Property<string>("Office")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("office");

                    b.Property<string>("Speciality")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("speciality");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.HasIndex("ContactID")
                        .IsUnique();

                    b.ToTable("Docs");
                });

            modelBuilder.Entity("ClinicAngular.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<int>("ContactID")
                        .HasColumnType("integer")
                        .HasColumnName("contact_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<string>("MedicalHistory")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("medical_history");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.HasIndex("ContactID")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ClinicAngular.Models.Schedule", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<int>("DocID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("doc_id");

                    b.Property<int>("SettingID")
                        .HasColumnType("INTEGER")
                        .HasColumnName("setting_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("ClinicAngular.Models.Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("DataAppointment")
                        .HasColumnType("timestamp")
                        .HasColumnName("data_appointment");

                    b.Property<int>("Duration")
                        .HasColumnType("integer")
                        .HasColumnName("duration");

                    b.Property<int>("QtyAppointments")
                        .HasColumnType("integer")
                        .HasColumnName("qty_appointments");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("start_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.HasKey("ID");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ClinicAngular.Models.Contact", b =>
                {
                    b.HasOne("ClinicAngular.Models.Address", "Address")
                        .WithMany("Contacts")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("ClinicAngular.Models.Doc", b =>
                {
                    b.HasOne("ClinicAngular.Models.Contact", "Contact")
                        .WithOne("Doc")
                        .HasForeignKey("ClinicAngular.Models.Doc", "ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ClinicAngular.Models.Patient", b =>
                {
                    b.HasOne("ClinicAngular.Models.Contact", "Contact")
                        .WithOne("Patient")
                        .HasForeignKey("ClinicAngular.Models.Patient", "ContactID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ClinicAngular.Models.Address", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("ClinicAngular.Models.Contact", b =>
                {
                    b.Navigation("Doc");

                    b.Navigation("Patient");
                });
#pragma warning restore 612, 618
        }
    }
}
