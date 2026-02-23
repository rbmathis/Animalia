using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Zhangixalus;

/// <summary>
/// Abstract class for Zhangixalus (genus).
/// NCBI TaxId: 2725783
/// </summary>
public abstract class Zhangixalus : Rhacophoridae, IZhangixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zhangixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2725783;

    /// <inheritdoc />
    public virtual string GenusName => "Zhangixalus";

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
