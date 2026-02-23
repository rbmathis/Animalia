using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Porophryne;

/// <summary>
/// Abstract class for Porophryne (genus).
/// NCBI TaxId: 1569975
/// </summary>
public abstract class Porophryne : Antennariidae, IPorophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1569975;

    /// <inheritdoc />
    public virtual string GenusName => "Porophryne";

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
