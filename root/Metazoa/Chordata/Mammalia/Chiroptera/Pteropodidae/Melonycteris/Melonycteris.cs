using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Melonycteris;

/// <summary>
/// Abstract class for Melonycteris (genus).
/// NCBI TaxId: 58074
/// </summary>
public abstract class Melonycteris : Pteropodidae, IMelonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58074;

    /// <inheritdoc />
    public virtual string GenusName => "Melonycteris";

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
