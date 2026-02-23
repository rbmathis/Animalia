using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Histrio;

/// <summary>
/// Abstract class for Histrio (genus).
/// NCBI TaxId: 242980
/// </summary>
public abstract class Histrio : Antennariidae, IHistrio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Histrio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242980;

    /// <inheritdoc />
    public virtual string GenusName => "Histrio";

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
