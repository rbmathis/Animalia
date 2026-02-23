using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Gardnerycteris;

/// <summary>
/// Abstract class for Gardnerycteris (genus).
/// NCBI TaxId: 1920523
/// </summary>
public abstract class Gardnerycteris : Phyllostomidae, IGardnerycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gardnerycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1920523;

    /// <inheritdoc />
    public virtual string GenusName => "Gardnerycteris";

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
