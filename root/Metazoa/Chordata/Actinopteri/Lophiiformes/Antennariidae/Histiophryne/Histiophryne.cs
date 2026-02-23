using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Histiophryne;

/// <summary>
/// Abstract class for Histiophryne (genus).
/// NCBI TaxId: 561726
/// </summary>
public abstract class Histiophryne : Antennariidae, IHistiophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histiophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 561726;

    /// <inheritdoc />
    public virtual string GenusName => "Histiophryne";

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
