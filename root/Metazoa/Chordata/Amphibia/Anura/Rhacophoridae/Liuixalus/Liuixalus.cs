using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Liuixalus;

/// <summary>
/// Abstract class for Liuixalus (genus).
/// NCBI TaxId: 979184
/// </summary>
public abstract class Liuixalus : Rhacophoridae, ILiuixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liuixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 979184;

    /// <inheritdoc />
    public virtual string GenusName => "Liuixalus";

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
