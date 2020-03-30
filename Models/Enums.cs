namespace APCRM.Models
{
    static class Enums
    {
        public enum Antipattern
        {
            AntiSingleton,
            BaseClassKnowsDerivedClass,
            BaseClassShouldBeAbstract,
            Blob,
            ClassDataShouldBePrivate,
            ComplexClass,
            FunctionalDecomposition,
            LargeClass,
            LazyClass,
            LongMethod,
            LongParameterList,
            ManyFieldAttributesButNotComplex,
            MessageChains,
            RefusedParentBequest,
            SpaghettiCode,
            SpeculativeGenerality,
            SwissArmyKnife,
            TraditionBreaker
        }

        public enum ClassRole
        {
            InformationHolder,
            Structurer,
            ServiceProvider,
            Controller,
            Coordinator,
            Interfacer
        }
    }
}
