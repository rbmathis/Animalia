using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Nasutixalus;

/// <summary>
/// Abstract class for Nasutixalus (genus).
/// NCBI TaxId: 1793881
/// </summary>
public abstract class Nasutixalus : Rhacophoridae, INasutixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nasutixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1793881;

    /// <inheritdoc />
    public virtual string GenusName => "Nasutixalus";

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
