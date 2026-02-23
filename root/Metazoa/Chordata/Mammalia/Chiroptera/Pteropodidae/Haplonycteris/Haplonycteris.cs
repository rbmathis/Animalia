using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Haplonycteris;

/// <summary>
/// Abstract class for Haplonycteris (genus).
/// NCBI TaxId: 301157
/// </summary>
public abstract class Haplonycteris : Pteropodidae, IHaplonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haplonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 301157;

    /// <inheritdoc />
    public virtual string GenusName => "Haplonycteris";

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
