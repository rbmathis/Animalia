using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Taruga;

/// <summary>
/// Abstract class for Taruga (genus).
/// NCBI TaxId: 1917153
/// </summary>
public abstract class Taruga : Rhacophoridae, ITaruga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taruga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1917153;

    /// <inheritdoc />
    public virtual string GenusName => "Taruga";

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
