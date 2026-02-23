using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Micronycteris;

/// <summary>
/// Abstract class for Micronycteris (genus).
/// NCBI TaxId: 148056
/// </summary>
public abstract class Micronycteris : Phyllostomidae, IMicronycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micronycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148056;

    /// <inheritdoc />
    public virtual string GenusName => "Micronycteris";

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
