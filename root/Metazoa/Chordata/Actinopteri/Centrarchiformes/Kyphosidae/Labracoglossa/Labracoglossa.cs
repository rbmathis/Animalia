using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Labracoglossa;

/// <summary>
/// Abstract class for Labracoglossa (genus).
/// NCBI TaxId: 163138
/// </summary>
public abstract class Labracoglossa : Kyphosidae, ILabracoglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labracoglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163138;

    /// <inheritdoc />
    public virtual string GenusName => "Labracoglossa";

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
