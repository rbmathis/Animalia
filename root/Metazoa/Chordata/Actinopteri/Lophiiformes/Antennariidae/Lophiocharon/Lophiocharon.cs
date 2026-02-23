using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Lophiocharon;

/// <summary>
/// Abstract class for Lophiocharon (genus).
/// NCBI TaxId: 561731
/// </summary>
public abstract class Lophiocharon : Antennariidae, ILophiocharon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiocharon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 561731;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiocharon";

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
