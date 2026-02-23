using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Tropidophiidae.Xenophidion;

/// <summary>
/// Abstract class for Xenophidion (genus).
/// NCBI TaxId: 267798
/// </summary>
public abstract class Xenophidion : Tropidophiidae, IXenophidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenophidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 267798;

    /// <inheritdoc />
    public virtual string GenusName => "Xenophidion";

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
