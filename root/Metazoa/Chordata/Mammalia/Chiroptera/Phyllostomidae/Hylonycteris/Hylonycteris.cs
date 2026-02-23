using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Hylonycteris;

/// <summary>
/// Abstract class for Hylonycteris (genus).
/// NCBI TaxId: 148044
/// </summary>
public abstract class Hylonycteris : Phyllostomidae, IHylonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148044;

    /// <inheritdoc />
    public virtual string GenusName => "Hylonycteris";

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
