using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinonycteridae.Cloeotis;

/// <summary>
/// Abstract class for Cloeotis (genus).
/// NCBI TaxId: 302399
/// </summary>
public abstract class Cloeotis : Rhinonycteridae, ICloeotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cloeotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302399;

    /// <inheritdoc />
    public virtual string GenusName => "Cloeotis";

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
