using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Ghatixalus;

/// <summary>
/// Abstract class for Ghatixalus (genus).
/// NCBI TaxId: 488249
/// </summary>
public abstract class Ghatixalus : Rhacophoridae, IGhatixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ghatixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 488249;

    /// <inheritdoc />
    public virtual string GenusName => "Ghatixalus";

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
