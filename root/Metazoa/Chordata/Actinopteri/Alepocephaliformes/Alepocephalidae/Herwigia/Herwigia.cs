using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Herwigia;

/// <summary>
/// Abstract class for Herwigia (genus).
/// NCBI TaxId: 492041
/// </summary>
public abstract class Herwigia : Alepocephalidae, IHerwigia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Herwigia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492041;

    /// <inheritdoc />
    public virtual string GenusName => "Herwigia";

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
