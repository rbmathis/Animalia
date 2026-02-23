using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Sphaeronycteris;

/// <summary>
/// Abstract class for Sphaeronycteris (genus).
/// NCBI TaxId: 148029
/// </summary>
public abstract class Sphaeronycteris : Phyllostomidae, ISphaeronycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaeronycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148029;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaeronycteris";

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
