using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Glyphonycteris;

/// <summary>
/// Abstract class for Glyphonycteris (genus).
/// NCBI TaxId: 409028
/// </summary>
public abstract class Glyphonycteris : Phyllostomidae, IGlyphonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyphonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 409028;

    /// <inheritdoc />
    public virtual string GenusName => "Glyphonycteris";

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
