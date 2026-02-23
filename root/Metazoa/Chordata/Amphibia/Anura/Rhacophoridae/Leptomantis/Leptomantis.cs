using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Leptomantis;

/// <summary>
/// Abstract class for Leptomantis (genus).
/// NCBI TaxId: 2782528
/// </summary>
public abstract class Leptomantis : Rhacophoridae, ILeptomantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptomantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2782528;

    /// <inheritdoc />
    public virtual string GenusName => "Leptomantis";

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
