using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes;

/// <summary>
/// Abstract class for Myodes (genus).
/// NCBI TaxId: 447134
/// </summary>
public abstract class Myodes : Cricetidae, IMyodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 447134;

    /// <inheritdoc />
    public virtual string GenusName => "Myodes";

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
