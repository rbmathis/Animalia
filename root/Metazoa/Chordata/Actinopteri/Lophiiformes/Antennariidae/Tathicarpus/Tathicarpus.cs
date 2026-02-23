using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Tathicarpus;

/// <summary>
/// Abstract class for Tathicarpus (genus).
/// NCBI TaxId: 242968
/// </summary>
public abstract class Tathicarpus : Antennariidae, ITathicarpus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tathicarpus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242968;

    /// <inheritdoc />
    public virtual string GenusName => "Tathicarpus";

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
