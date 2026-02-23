using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Gracixalus;

/// <summary>
/// Abstract class for Gracixalus (genus).
/// NCBI TaxId: 311576
/// </summary>
public abstract class Gracixalus : Rhacophoridae, IGracixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311576;

    /// <inheritdoc />
    public virtual string GenusName => "Gracixalus";

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
