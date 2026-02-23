using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia;

/// <summary>
/// Abstract class for Mammalia (class).
/// NCBI TaxId: 40674
/// </summary>
public abstract class Mammalia : Chordata, IMammalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mammalia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "class";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40674;

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
