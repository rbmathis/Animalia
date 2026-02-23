using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Leptoderma;

/// <summary>
/// Abstract class for Leptoderma (genus).
/// NCBI TaxId: 492043
/// </summary>
public abstract class Leptoderma : Alepocephalidae, ILeptoderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492043;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoderma";

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
