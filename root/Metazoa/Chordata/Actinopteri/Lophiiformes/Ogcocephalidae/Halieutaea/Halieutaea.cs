using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halieutaea;

/// <summary>
/// Abstract class for Halieutaea (genus).
/// NCBI TaxId: 215328
/// </summary>
public abstract class Halieutaea : Ogcocephalidae, IHalieutaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halieutaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215328;

    /// <inheritdoc />
    public virtual string GenusName => "Halieutaea";

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
