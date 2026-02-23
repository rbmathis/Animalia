using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Conocara;

/// <summary>
/// Abstract class for Conocara (genus).
/// NCBI TaxId: 492035
/// </summary>
public abstract class Conocara : Alepocephalidae, IConocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 492035;

    /// <inheritdoc />
    public virtual string GenusName => "Conocara";

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
