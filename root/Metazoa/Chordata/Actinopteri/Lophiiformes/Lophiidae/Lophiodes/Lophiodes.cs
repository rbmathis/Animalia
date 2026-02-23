using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophiodes;

/// <summary>
/// Abstract class for Lophiodes (genus).
/// NCBI TaxId: 314248
/// </summary>
public abstract class Lophiodes : Lophiidae, ILophiodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 314248;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiodes";

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
