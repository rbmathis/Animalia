using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Beddomixalus;

/// <summary>
/// Abstract class for Beddomixalus (genus).
/// NCBI TaxId: 1323770
/// </summary>
public abstract class Beddomixalus : Rhacophoridae, IBeddomixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Beddomixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1323770;

    /// <inheritdoc />
    public virtual string GenusName => "Beddomixalus";

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
