using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Lophiomus;

/// <summary>
/// Abstract class for Lophiomus (genus).
/// NCBI TaxId: 292416
/// </summary>
public abstract class Lophiomus : Lophiidae, ILophiomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophiomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292416;

    /// <inheritdoc />
    public virtual string GenusName => "Lophiomus";

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
