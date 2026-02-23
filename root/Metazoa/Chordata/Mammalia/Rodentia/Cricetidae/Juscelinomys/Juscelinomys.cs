using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Juscelinomys;

/// <summary>
/// Abstract class for Juscelinomys (genus).
/// NCBI TaxId: 106102
/// </summary>
public abstract class Juscelinomys : Cricetidae, IJuscelinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Juscelinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106102;

    /// <inheritdoc />
    public virtual string GenusName => "Juscelinomys";

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
