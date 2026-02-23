using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xantusiidae.Lepidophyma;

/// <summary>
/// Abstract class for Lepidophyma (genus).
/// NCBI TaxId: 8541
/// </summary>
public abstract class Lepidophyma : Xantusiidae, ILepidophyma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidophyma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8541;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidophyma";

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
