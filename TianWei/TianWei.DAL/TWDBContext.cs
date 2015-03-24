/*
 * -------------------------------------------------------------------------------
 * 版权信息：	韩天伟（hantianwei.cn）	版权所有	2015
 * 功能描述：	代码处成器生成
 * 
 * 创建人：　	代码生成
 * 创建日期：	2015-03-24 20:31:08
 * 创建说明：	
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 *    
 * -------------------------------------------------------------------------------
 */
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TianWei.Model;
using TianWei.Enums;
using TianWei.Utility;
using System.Data.Common;

namespace TianWei.DAL
{
    /// <summary>
    ///   数据访问层上下文
    /// </summary>
    public partial class TWDBContext : DbContext
    {

	    static TWDBContext()
        {
            Database.SetInitializer<TWDBContext>(null);
        }

        public TWDBContext(WriteRead writeRead)
            : base(writeRead == WriteRead.Write ? DBConfig.Write : DBConfig.Read)
        {
        }

		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TestTable> TestTable { get; set; }
		        
        /// <summary>
        /// 专家表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_Experts> TT_Account_Experts { get; set; }
		        
        /// <summary>
        /// 专家学科表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_ExpertSubjects> TT_Account_ExpertSubjects { get; set; }
		        
        /// <summary>
        /// 功能项表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_FunctionItems> TT_Account_FunctionItems { get; set; }
		        
        /// <summary>
        /// 管理员表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_Manager> TT_Account_Manager { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Account_Message> TT_Account_Message { get; set; }
		        
        /// <summary>
        /// 角色表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_Role> TT_Account_Role { get; set; }
		        
        /// <summary>
        /// 角色权限表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_RolePermission> TT_Account_RolePermission { get; set; }
		        
        /// <summary>
        /// 教师基本信数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherBasic> TT_Account_TeacherBasic { get; set; }
		        
        /// <summary>
        /// 教师主要任数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherCaseCurriculum> TT_Account_TeacherCaseCurriculum { get; set; }
		        
        /// <summary>
        /// 专任教师情数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherCaseFullTime> TT_Account_TeacherCaseFullTime { get; set; }
		        
        /// <summary>
        /// 教师近三年数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherCaseTrainingSituation> TT_Account_TeacherCaseTrainingSituation { get; set; }
		        
        /// <summary>
        /// 教师劳资信数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherLabourInformation> TT_Account_TeacherLabourInformation { get; set; }
		        
        /// <summary>
        /// 教师异动表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherMove> TT_Account_TeacherMove { get; set; }
		        
        /// <summary>
        /// 教师岗位类数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherPostCategory> TT_Account_TeacherPostCategory { get; set; }
		        
        /// <summary>
        /// 教师岗位等数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherPostGrades> TT_Account_TeacherPostGrades { get; set; }
		        
        /// <summary>
        /// 教师调离表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_TeacherResignation> TT_Account_TeacherResignation { get; set; }
		        
        /// <summary>
        /// 用户账号表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_UserCenter> TT_Account_UserCenter { get; set; }
		        
        /// <summary>
        /// 用户权限表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_UserPermission> TT_Account_UserPermission { get; set; }
		        
        /// <summary>
        /// 用户角色表数据访问上下文
        /// </summary>
		public DbSet<TT_Account_UserRole> TT_Account_UserRole { get; set; }
		        
        /// <summary>
        /// 行政区域表数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_AdministrativeRegions> TT_Basic_AdministrativeRegions { get; set; }
		        
        /// <summary>
        /// 行政单位管数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_AdministrativeUnit> TT_Basic_AdministrativeUnit { get; set; }
		        
        /// <summary>
        /// 个人特殊学数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_Clause> TT_Basic_Clause { get; set; }
		        
        /// <summary>
        /// 补学约束条数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_MakeLearningCondition> TT_Basic_MakeLearningCondition { get; set; }
		        
        /// <summary>
        /// 机构类型说数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_OrgType> TT_Basic_OrgType { get; set; }
		        
        /// <summary>
        /// 学校表数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_School> TT_Basic_School { get; set; }
		        
        /// <summary>
        /// 结构学分表数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_StructureCredit> TT_Basic_StructureCredit { get; set; }
		        
        /// <summary>
        /// 培训机构表数据访问上下文
        /// </summary>
		public DbSet<TT_Basic_TrainingProviders> TT_Basic_TrainingProviders { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Certificate_Basic> TT_Certificate_Basic { get; set; }
		        
        /// <summary>
        /// 个人特殊学数据访问上下文
        /// </summary>
		public DbSet<TT_Credit_IndividualSpecialCredits> TT_Credit_IndividualSpecialCredits { get; set; }
		        
        /// <summary>
        /// 教师奖惩表数据访问上下文
        /// </summary>
		public DbSet<TT_Credit_RewardPunishment> TT_Credit_RewardPunishment { get; set; }
		        
        /// <summary>
        /// 校本研修学数据访问上下文
        /// </summary>
		public DbSet<TT_Credit_SchoolBasedTrainingCredit> TT_Credit_SchoolBasedTrainingCredit { get; set; }
		        
        /// <summary>
        /// 行政职务表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_AdministrativeDuties> TT_Dic_AdministrativeDuties { get; set; }
		        
        /// <summary>
        /// 机构性质数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_AgencyNature> TT_Dic_AgencyNature { get; set; }
		        
        /// <summary>
        /// 机构资质数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_AgencyQualification> TT_Dic_AgencyQualification { get; set; }
		        
        /// <summary>
        /// 考核评价数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Appraisal> TT_Dic_Appraisal { get; set; }
		        
        /// <summary>
        /// 教师资格证数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_CertificateType> TT_Dic_CertificateType { get; set; }
		        
        /// <summary>
        /// 选学主体数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ChooseSubject> TT_Dic_ChooseSubject { get; set; }
		        
        /// <summary>
        /// 签订合同情数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ContractSituation> TT_Dic_ContractSituation { get; set; }
		        
        /// <summary>
        /// 国家地区表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Country> TT_Dic_Country { get; set; }
		        
        /// <summary>
        /// 考核方式数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_CourseAssessType> TT_Dic_CourseAssessType { get; set; }
		        
        /// <summary>
        /// 课程类别表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_CourseCategory> TT_Dic_CourseCategory { get; set; }
		        
        /// <summary>
        /// 教学方法数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_CourseTeachingMethods> TT_Dic_CourseTeachingMethods { get; set; }
		        
        /// <summary>
        /// 任教课程表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Curriculum> TT_Dic_Curriculum { get; set; }
		        
        /// <summary>
        /// 学位数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Degree> TT_Dic_Degree { get; set; }
		        
        /// <summary>
        /// 学历数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_EducationalBackground> TT_Dic_EducationalBackground { get; set; }
		        
        /// <summary>
        /// 专家类别数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ExpertCategory> TT_Dic_ExpertCategory { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ExpertPost> TT_Dic_ExpertPost { get; set; }
		        
        /// <summary>
        /// 五险一金表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_FiveInsurancePayments> TT_Dic_FiveInsurancePayments { get; set; }
		        
        /// <summary>
        /// 免费师范生数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_FreeNormalStudent> TT_Dic_FreeNormalStudent { get; set; }
		        
        /// <summary>
        /// 身份证件类数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_IDType> TT_Dic_IDType { get; set; }
		        
        /// <summary>
        /// 任课学段表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_LearningSegment> TT_Dic_LearningSegment { get; set; }
		        
        /// <summary>
        /// 普通话等级数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_MandarinLevel> TT_Dic_MandarinLevel { get; set; }
		        
        /// <summary>
        /// 民族表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Nation> TT_Dic_Nation { get; set; }
		        
        /// <summary>
        /// 专业技术职数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PilotProject> TT_Dic_PilotProject { get; set; }
		        
        /// <summary>
        /// 政治面貌表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Politicallandscape> TT_Dic_Politicallandscape { get; set; }
		        
        /// <summary>
        /// 门户下载专数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PortalDownloadType> TT_Dic_PortalDownloadType { get; set; }
		        
        /// <summary>
        /// 门户通知公数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PortalNoticeType> TT_Dic_PortalNoticeType { get; set; }
		        
        /// <summary>
        /// 门户政策文数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PortalPolicyFileType> TT_Dic_PortalPolicyFileType { get; set; }
		        
        /// <summary>
        /// 岗位类别表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PostCategory> TT_Dic_PostCategory { get; set; }
		        
        /// <summary>
        /// 岗位等级表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_PostGrades> TT_Dic_PostGrades { get; set; }
		        
        /// <summary>
        /// 项目评审项数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ProAuditItems> TT_Dic_ProAuditItems { get; set; }
		        
        /// <summary>
        /// 项目类型数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_ProjectType> TT_Dic_ProjectType { get; set; }
		        
        /// <summary>
        /// 教师奖惩表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_RewardPunishment> TT_Dic_RewardPunishment { get; set; }
		        
        /// <summary>
        /// 学校类别数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_SchoolCategory> TT_Dic_SchoolCategory { get; set; }
		        
        /// <summary>
        /// 学校性质数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_SchoolNature> TT_Dic_SchoolNature { get; set; }
		        
        /// <summary>
        /// 学段数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_SchoolStage> TT_Dic_SchoolStage { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_SchoolStageRefSubject> TT_Dic_SchoolStageRefSubject { get; set; }
		        
        /// <summary>
        /// 性别表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Sex> TT_Dic_Sex { get; set; }
		        
        /// <summary>
        /// 特岗教师表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_SpecialPost> TT_Dic_SpecialPost { get; set; }
		        
        /// <summary>
        /// 专业数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Specialty> TT_Dic_Specialty { get; set; }
		        
        /// <summary>
        /// 学科数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Subject> TT_Dic_Subject { get; set; }
		        
        /// <summary>
        /// 数据字典总数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Tables> TT_Dic_Tables { get; set; }
		        
        /// <summary>
        /// 教师类别数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TeachersCategory> TT_Dic_TeachersCategory { get; set; }
		        
        /// <summary>
        /// 任教年级数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TeachGrades> TT_Dic_TeachGrades { get; set; }
		        
        /// <summary>
        /// 职称数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_Title> TT_Dic_Title { get; set; }
		        
        /// <summary>
        /// 培训类别数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TrainingCategory> TT_Dic_TrainingCategory { get; set; }
		        
        /// <summary>
        /// 培训形式数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TrainingForms> TT_Dic_TrainingForms { get; set; }
		        
        /// <summary>
        /// 培训层级数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TrainingLevel> TT_Dic_TrainingLevel { get; set; }
		        
        /// <summary>
        /// 培训对象数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TrainingObject> TT_Dic_TrainingObject { get; set; }
		        
        /// <summary>
        /// 受训情况表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_TrainingRange> TT_Dic_TrainingRange { get; set; }
		        
        /// <summary>
        /// 专业技术职数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_UnPilotProject> TT_Dic_UnPilotProject { get; set; }
		        
        /// <summary>
        /// 是否在编表数据访问上下文
        /// </summary>
		public DbSet<TT_Dic_YesNo> TT_Dic_YesNo { get; set; }
		        
        /// <summary>
        /// 批次专家表数据访问上下文
        /// </summary>
		public DbSet<TT_Expert_BatchExpert> TT_Expert_BatchExpert { get; set; }
		        
        /// <summary>
        /// 培训专家评数据访问上下文
        /// </summary>
		public DbSet<TT_Expert_ExpertAudit> TT_Expert_ExpertAudit { get; set; }
		        
        /// <summary>
        /// 专家评审项数据访问上下文
        /// </summary>
		public DbSet<TT_Expert_ExpertAuditItems> TT_Expert_ExpertAuditItems { get; set; }
		        
        /// <summary>
        /// 专家评审任数据访问上下文
        /// </summary>
		public DbSet<TT_Expert_TaskAssignment> TT_Expert_TaskAssignment { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Index_Article> TT_Index_Article { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Index_Download> TT_Index_Download { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Index_Notice> TT_Index_Notice { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Index_PolicyFile> TT_Index_PolicyFile { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_Index_SinglePage> TT_Index_SinglePage { get; set; }
		        
        /// <summary>
        /// 公告表数据访问上下文
        /// </summary>
		public DbSet<TT_Info_Notice> TT_Info_Notice { get; set; }
		        
        /// <summary>
        /// 公告附属表数据访问上下文
        /// </summary>
		public DbSet<TT_Info_NoticeAttached> TT_Info_NoticeAttached { get; set; }
		        
        /// <summary>
        /// 栏目管理数据访问上下文
        /// </summary>
		public DbSet<TT_Info_PortalColumn> TT_Info_PortalColumn { get; set; }
		        
        /// <summary>
        /// 下载文件类数据访问上下文
        /// </summary>
		public DbSet<TT_Info_PortalDownloadCategory> TT_Info_PortalDownloadCategory { get; set; }
		        
        /// <summary>
        /// 下载专区数据访问上下文
        /// </summary>
		public DbSet<TT_Info_PortalDownloadZone> TT_Info_PortalDownloadZone { get; set; }
		        
        /// <summary>
        /// 政策文件数据访问上下文
        /// </summary>
		public DbSet<TT_Info_PortalPolicyDocument> TT_Info_PortalPolicyDocument { get; set; }
		        
        /// <summary>
        /// 通知公告数据访问上下文
        /// </summary>
		public DbSet<TT_Info_PortalPolicyNotice> TT_Info_PortalPolicyNotice { get; set; }
		        
        /// <summary>
        /// 评估公示数据访问上下文
        /// </summary>
		public DbSet<TT_PE_Publicity> TT_PE_Publicity { get; set; }
		        
        /// <summary>
        /// 调查问卷数据访问上下文
        /// </summary>
		public DbSet<TT_PE_Questionnaire> TT_PE_Questionnaire { get; set; }
		        
        /// <summary>
        /// 调查题目表数据访问上下文
        /// </summary>
		public DbSet<TT_PE_QuestionnaireItems> TT_PE_QuestionnaireItems { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_PE_QuestionnaireObject> TT_PE_QuestionnaireObject { get; set; }
		        
        /// <summary>
        /// 调查题目选数据访问上下文
        /// </summary>
		public DbSet<TT_PE_QuestionnaireOptions> TT_PE_QuestionnaireOptions { get; set; }
		        
        /// <summary>
        /// 调查范围数据访问上下文
        /// </summary>
		public DbSet<TT_PE_QuestionnaireRange> TT_PE_QuestionnaireRange { get; set; }
		        
        /// <summary>
        /// 调查结果数据访问上下文
        /// </summary>
		public DbSet<TT_PE_QuestionnaireResult> TT_PE_QuestionnaireResult { get; set; }
		        
        /// <summary>
        /// 机构自评报数据访问上下文
        /// </summary>
		public DbSet<TT_PE_SelfAssessmentReport> TT_PE_SelfAssessmentReport { get; set; }
		        
        /// <summary>
        /// 项目批次表数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_Batch> TT_ProManage_Batch { get; set; }
		        
        /// <summary>
        /// 批次培训规数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_BatchPlanDetail> TT_ProManage_BatchPlanDetail { get; set; }
		        
        /// <summary>
        /// 批次培训规数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_BatchPlanManage> TT_ProManage_BatchPlanManage { get; set; }
		        
        /// <summary>
        /// 批次培训学数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_BatchSubject> TT_ProManage_BatchSubject { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_CourseResources> TT_ProManage_CourseResources { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_CPProDeclare> TT_ProManage_CPProDeclare { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_CPProSchoolStageSubject> TT_ProManage_CPProSchoolStageSubject { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_CPQuotaAllocation> TT_ProManage_CPQuotaAllocation { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_CPQuotaAllocationPublishStateInfo> TT_ProManage_CPQuotaAllocationPublishStateInfo { get; set; }
		        
        /// <summary>
        /// 学情通报表数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_LearningAbout> TT_ProManage_LearningAbout { get; set; }
		        
        /// <summary>
        /// 项目发布对数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ObjectRange> TT_ProManage_ObjectRange { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_PaymentAudit> TT_ProManage_PaymentAudit { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProAuditItems> TT_ProManage_ProAuditItems { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProConcreteAuditItems> TT_ProManage_ProConcreteAuditItems { get; set; }
		        
        /// <summary>
        /// 项目培训课数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProCourse> TT_ProManage_ProCourse { get; set; }
		        
        /// <summary>
        /// 项目课程考数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProCourseAssessType> TT_ProManage_ProCourseAssessType { get; set; }
		        
        /// <summary>
        /// 项目课程教数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProCourseTeachMethods> TT_ProManage_ProCourseTeachMethods { get; set; }
		        
        /// <summary>
        /// 项目申报表数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProDeclare> TT_ProManage_ProDeclare { get; set; }
		        
        /// <summary>
        /// 项目申报评数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProDeclareAudit> TT_ProManage_ProDeclareAudit { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProDeclareAuditItems> TT_ProManage_ProDeclareAuditItems { get; set; }
		        
        /// <summary>
        /// 批次项目评数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProjectJudgingItem> TT_ProManage_ProjectJudgingItem { get; set; }
		        
        /// <summary>
        /// 数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProProposal> TT_ProManage_ProProposal { get; set; }
		        
        /// <summary>
        /// 项目资源表数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_ProResouce> TT_ProManage_ProResouce { get; set; }
		        
        /// <summary>
        /// 项目选学报数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_SignUp> TT_ProManage_SignUp { get; set; }
		        
        /// <summary>
        /// 选学审核表数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_SignUpAuditDetail> TT_ProManage_SignUpAuditDetail { get; set; }
		        
        /// <summary>
        /// 项目培训结数据访问上下文
        /// </summary>
		public DbSet<TT_ProManage_TrainingResult> TT_ProManage_TrainingResult { get; set; }
		        
        /// <summary>
        /// 培训规划表数据访问上下文
        /// </summary>
		public DbSet<TT_ProPlan_PlanManage> TT_ProPlan_PlanManage { get; set; }
		        
        /// <summary>
        /// 项目规划评数据访问上下文
        /// </summary>
		public DbSet<TT_ProPlan_ProjectJudgingItem> TT_ProPlan_ProjectJudgingItem { get; set; }
		        
        /// <summary>
        /// 培训学科数据访问上下文
        /// </summary>
		public DbSet<TT_ProPlan_Subjects> TT_ProPlan_Subjects { get; set; }
		        
        /// <summary>
        /// 学员补学申数据访问上下文
        /// </summary>
		public DbSet<TT_Score_MakeLearningApp> TT_Score_MakeLearningApp { get; set; }
		        
        /// <summary>
        /// 学员补学审数据访问上下文
        /// </summary>
		public DbSet<TT_Score_MakeLearningAudit> TT_Score_MakeLearningAudit { get; set; }
		        
        /// <summary>
        /// 学员补学项数据访问上下文
        /// </summary>
		public DbSet<TT_Score_MakeLearningCourse> TT_Score_MakeLearningCourse { get; set; }
		        
        /// <summary>
        /// 学员成绩表数据访问上下文
        /// </summary>
		public DbSet<TT_Score_TraineeScore> TT_Score_TraineeScore { get; set; }
		        
        /// <summary>
        /// 成绩审核表数据访问上下文
        /// </summary>
		public DbSet<TT_Score_TraineeScoreAudit> TT_Score_TraineeScoreAudit { get; set; }
		
    }
}
