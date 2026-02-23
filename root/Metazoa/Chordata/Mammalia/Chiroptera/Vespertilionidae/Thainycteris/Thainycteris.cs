using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Thainycteris;

/// <summary>
/// Abstract class for Thainycteris (genus).
/// NCBI TaxId: 3371075
/// </summary>
public abstract class Thainycteris : Vespertilionidae, IThainycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thainycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371075;

    /// <inheritdoc />
    public virtual string GenusName => "Thainycteris";

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
