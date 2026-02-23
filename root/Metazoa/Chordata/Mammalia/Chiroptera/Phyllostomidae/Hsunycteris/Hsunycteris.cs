using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Hsunycteris;

/// <summary>
/// Abstract class for Hsunycteris (genus).
/// NCBI TaxId: 1470803
/// </summary>
public abstract class Hsunycteris : Phyllostomidae, IHsunycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hsunycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1470803;

    /// <inheritdoc />
    public virtual string GenusName => "Hsunycteris";

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
