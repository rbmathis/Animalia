using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Furipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Furipteridae.Furipterus;

/// <summary>
/// Abstract class for Furipterus (genus).
/// NCBI TaxId: 148081
/// </summary>
public abstract class Furipterus : Furipteridae, IFuripterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Furipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148081;

    /// <inheritdoc />
    public virtual string GenusName => "Furipterus";

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
