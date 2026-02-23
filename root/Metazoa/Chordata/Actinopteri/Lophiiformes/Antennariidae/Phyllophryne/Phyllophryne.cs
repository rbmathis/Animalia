using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Phyllophryne;

/// <summary>
/// Abstract class for Phyllophryne (genus).
/// NCBI TaxId: 632147
/// </summary>
public abstract class Phyllophryne : Antennariidae, IPhyllophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 632147;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllophryne";

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
