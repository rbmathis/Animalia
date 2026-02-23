using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Narcetes;

/// <summary>
/// Abstract class for Narcetes (genus).
/// NCBI TaxId: 443643
/// </summary>
public abstract class Narcetes : Alepocephalidae, INarcetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Narcetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443643;

    /// <inheritdoc />
    public virtual string GenusName => "Narcetes";

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
