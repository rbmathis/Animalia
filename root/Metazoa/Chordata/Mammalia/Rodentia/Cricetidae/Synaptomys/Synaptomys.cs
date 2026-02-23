using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Synaptomys;

/// <summary>
/// Abstract class for Synaptomys (genus).
/// NCBI TaxId: 98317
/// </summary>
public abstract class Synaptomys : Cricetidae, ISynaptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synaptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98317;

    /// <inheritdoc />
    public virtual string GenusName => "Synaptomys";

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
