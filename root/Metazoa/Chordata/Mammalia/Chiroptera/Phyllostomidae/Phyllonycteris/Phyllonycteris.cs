using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Phyllonycteris;

/// <summary>
/// Abstract class for Phyllonycteris (genus).
/// NCBI TaxId: 138701
/// </summary>
public abstract class Phyllonycteris : Phyllostomidae, IPhyllonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 138701;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllonycteris";

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
