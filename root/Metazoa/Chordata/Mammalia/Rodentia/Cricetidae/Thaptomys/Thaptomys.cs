using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thaptomys;

/// <summary>
/// Abstract class for Thaptomys (genus).
/// NCBI TaxId: 587435
/// </summary>
public abstract class Thaptomys : Cricetidae, IThaptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thaptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587435;

    /// <inheritdoc />
    public virtual string GenusName => "Thaptomys";

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
