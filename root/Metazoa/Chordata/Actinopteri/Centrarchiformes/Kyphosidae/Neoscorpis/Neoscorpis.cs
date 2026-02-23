using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Neoscorpis;

/// <summary>
/// Abstract class for Neoscorpis (genus).
/// NCBI TaxId: 490336
/// </summary>
public abstract class Neoscorpis : Kyphosidae, INeoscorpis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoscorpis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490336;

    /// <inheritdoc />
    public virtual string GenusName => "Neoscorpis";

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
