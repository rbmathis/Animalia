using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Trinycteris;

/// <summary>
/// Abstract class for Trinycteris (genus).
/// NCBI TaxId: 3477446
/// </summary>
public abstract class Trinycteris : Phyllostomidae, ITrinycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trinycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3477446;

    /// <inheritdoc />
    public virtual string GenusName => "Trinycteris";

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
