using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Phascogale;

/// <summary>
/// Abstract class for Phascogale (genus).
/// NCBI TaxId: 9292
/// </summary>
public abstract class Phascogale : Dasyuridae, IPhascogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phascogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9292;

    /// <inheritdoc />
    public virtual string GenusName => "Phascogale";

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
