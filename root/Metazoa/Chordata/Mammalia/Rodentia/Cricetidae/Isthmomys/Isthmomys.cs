using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Isthmomys;

/// <summary>
/// Abstract class for Isthmomys (genus).
/// NCBI TaxId: 56320
/// </summary>
public abstract class Isthmomys : Cricetidae, IIsthmomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isthmomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56320;

    /// <inheritdoc />
    public virtual string GenusName => "Isthmomys";

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
