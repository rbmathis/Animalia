using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Myonycteris;

/// <summary>
/// Abstract class for Myonycteris (genus).
/// NCBI TaxId: 77236
/// </summary>
public abstract class Myonycteris : Pteropodidae, IMyonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77236;

    /// <inheritdoc />
    public virtual string GenusName => "Myonycteris";

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
