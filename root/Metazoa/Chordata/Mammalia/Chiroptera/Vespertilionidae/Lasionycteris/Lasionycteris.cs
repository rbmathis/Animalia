using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Lasionycteris;

/// <summary>
/// Abstract class for Lasionycteris (genus).
/// NCBI TaxId: 27666
/// </summary>
public abstract class Lasionycteris : Vespertilionidae, ILasionycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lasionycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27666;

    /// <inheritdoc />
    public virtual string GenusName => "Lasionycteris";

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
