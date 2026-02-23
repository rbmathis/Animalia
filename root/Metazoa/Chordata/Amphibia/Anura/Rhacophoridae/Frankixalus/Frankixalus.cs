using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Frankixalus;

/// <summary>
/// Abstract class for Frankixalus (genus).
/// NCBI TaxId: 1783540
/// </summary>
public abstract class Frankixalus : Rhacophoridae, IFrankixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Frankixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1783540;

    /// <inheritdoc />
    public virtual string GenusName => "Frankixalus";

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
