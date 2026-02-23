using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Afrosoricida.Chrysochloridae.Chrysospalax;

/// <summary>
/// Abstract class for Chrysospalax (genus).
/// NCBI TaxId: 176107
/// </summary>
public abstract class Chrysospalax : Chrysochloridae, IChrysospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176107;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysospalax";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
