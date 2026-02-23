using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennarius;

/// <summary>
/// Abstract class for Antennarius (genus).
/// NCBI TaxId: 242978
/// </summary>
public abstract class Antennarius : Antennariidae, IAntennarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antennarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242978;

    /// <inheritdoc />
    public virtual string GenusName => "Antennarius";

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
