using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Scorpis;

/// <summary>
/// Abstract class for Scorpis (genus).
/// NCBI TaxId: 163140
/// </summary>
public abstract class Scorpis : Kyphosidae, IScorpis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163140;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpis";

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
