using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Abantennarius;

/// <summary>
/// Abstract class for Abantennarius (genus).
/// NCBI TaxId: 2919612
/// </summary>
public abstract class Abantennarius : Antennariidae, IAbantennarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abantennarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2919612;

    /// <inheritdoc />
    public virtual string GenusName => "Abantennarius";

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
