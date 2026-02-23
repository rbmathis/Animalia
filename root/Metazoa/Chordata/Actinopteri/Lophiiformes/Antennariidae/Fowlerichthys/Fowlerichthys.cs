using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Fowlerichthys;

/// <summary>
/// Abstract class for Fowlerichthys (genus).
/// NCBI TaxId: 1311547
/// </summary>
public abstract class Fowlerichthys : Antennariidae, IFowlerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fowlerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311547;

    /// <inheritdoc />
    public virtual string GenusName => "Fowlerichthys";

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
