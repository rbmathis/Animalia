using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.Cladistia;

/// <summary>
/// Abstract class for Cladistia (class).
/// NCBI TaxId: 1338366
/// </summary>
public abstract class Cladistia : Chordata, ICladistia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cladistia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "class";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1338366;

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
