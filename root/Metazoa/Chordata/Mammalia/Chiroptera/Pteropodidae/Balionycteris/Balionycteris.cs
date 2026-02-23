using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Balionycteris;

/// <summary>
/// Abstract class for Balionycteris (genus).
/// NCBI TaxId: 77228
/// </summary>
public abstract class Balionycteris : Pteropodidae, IBalionycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Balionycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77228;

    /// <inheritdoc />
    public virtual string GenusName => "Balionycteris";

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
