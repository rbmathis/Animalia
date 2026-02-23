using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Abstract class for Reithrodontomys (genus).
/// NCBI TaxId: 44233
/// </summary>
public abstract class Reithrodontomys : Cricetidae, IReithrodontomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reithrodontomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44233;

    /// <inheritdoc />
    public virtual string GenusName => "Reithrodontomys";

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
