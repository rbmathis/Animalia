using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Microcanthus;

/// <summary>
/// Abstract class for Microcanthus (genus).
/// NCBI TaxId: 163145
/// </summary>
public abstract class Microcanthus : Kyphosidae, IMicrocanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163145;

    /// <inheritdoc />
    public virtual string GenusName => "Microcanthus";

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
