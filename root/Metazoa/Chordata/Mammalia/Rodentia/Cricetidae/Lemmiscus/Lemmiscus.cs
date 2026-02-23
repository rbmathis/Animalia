using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmiscus;

/// <summary>
/// Abstract class for Lemmiscus (genus).
/// NCBI TaxId: 663698
/// </summary>
public abstract class Lemmiscus : Cricetidae, ILemmiscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lemmiscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 663698;

    /// <inheritdoc />
    public virtual string GenusName => "Lemmiscus";

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
