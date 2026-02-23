using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophius;

/// <summary>
/// Abstract class for Lophius (genus).
/// NCBI TaxId: 8072
/// </summary>
public abstract class Lophius : Lophiidae, ILophius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8072;

    /// <inheritdoc />
    public virtual string GenusName => "Lophius";

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
