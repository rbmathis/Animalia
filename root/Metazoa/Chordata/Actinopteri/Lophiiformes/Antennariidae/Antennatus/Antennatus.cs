using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennatus;

/// <summary>
/// Abstract class for Antennatus (genus).
/// NCBI TaxId: 882771
/// </summary>
public abstract class Antennatus : Antennariidae, IAntennatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antennatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882771;

    /// <inheritdoc />
    public virtual string GenusName => "Antennatus";

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
