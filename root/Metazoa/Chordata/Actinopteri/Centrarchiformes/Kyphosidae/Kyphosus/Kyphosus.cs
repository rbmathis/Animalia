using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Kyphosus;

/// <summary>
/// Abstract class for Kyphosus (genus).
/// NCBI TaxId: 163142
/// </summary>
public abstract class Kyphosus : Kyphosidae, IKyphosus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kyphosus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163142;

    /// <inheritdoc />
    public virtual string GenusName => "Kyphosus";

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
