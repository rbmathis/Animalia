using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Phrynoderma;

/// <summary>
/// Abstract class for Phrynoderma (genus).
/// NCBI TaxId: 2920390
/// </summary>
public abstract class Phrynoderma : Dicroglossidae, IPhrynoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2920390;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynoderma";

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
