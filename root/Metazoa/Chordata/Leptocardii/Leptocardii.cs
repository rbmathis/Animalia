using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii;

/// <summary>
/// Abstract class for Leptocardii (class).
/// NCBI TaxId: 2682552
/// </summary>
public abstract class Leptocardii : Chordata, ILeptocardii
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptocardii";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "class";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2682552;

    /// <inheritdoc />
    public virtual string ClassName => "Mammalia";

    /// <inheritdoc />
    public virtual string[] ClassCharacteristics => new[]
    {
        "Mammary glands present",
        "Hair or fur covering",
        "Three middle ear bones",
        "Neocortex in brain",
        "Specialized teeth"
    };

    /// <inheritdoc />
    public virtual bool HasMammaryGlands => true;

    /// <inheritdoc />
    public virtual bool HasHairOrFur => true;

    /// <inheritdoc />
    public virtual string DentitionPattern => "Heterodont";

    /// <inheritdoc />
    public virtual bool HasFourChamberedHeart => true;

    /// <inheritdoc />
    public virtual string GestationType => "Placental";

    /// <inheritdoc />
    public virtual bool IsEndothermic => true;

    /// <inheritdoc />
    public virtual string[] ThermoregulationMechanisms => new[]
    {
        "Metabolic heat generation",
        "Sweating",
        "Panting",
        "Vasoconstriction/vasodilation",
        "Insulating fur"
    };

}
