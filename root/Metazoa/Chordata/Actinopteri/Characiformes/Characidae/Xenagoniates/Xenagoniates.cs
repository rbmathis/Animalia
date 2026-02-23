using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Xenagoniates;

/// <summary>
/// Abstract class for Xenagoniates (genus).
/// NCBI TaxId: 930380
/// </summary>
public abstract class Xenagoniates : Characidae, IXenagoniates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenagoniates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930380;

    /// <inheritdoc />
    public virtual string GenusName => "Xenagoniates";

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
