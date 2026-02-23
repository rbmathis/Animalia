using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lionycteris;

/// <summary>
/// Abstract class for Lionycteris (genus).
/// NCBI TaxId: 148084
/// </summary>
public abstract class Lionycteris : Phyllostomidae, ILionycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lionycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148084;

    /// <inheritdoc />
    public virtual string GenusName => "Lionycteris";

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
