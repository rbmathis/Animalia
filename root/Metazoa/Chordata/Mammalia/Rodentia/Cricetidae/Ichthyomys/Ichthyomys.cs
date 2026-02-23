using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ichthyomys;

/// <summary>
/// Abstract class for Ichthyomys (genus).
/// NCBI TaxId: 2028559
/// </summary>
public abstract class Ichthyomys : Cricetidae, IIchthyomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2028559;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyomys";

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
