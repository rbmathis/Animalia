using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Maulisia;

/// <summary>
/// Abstract class for Maulisia (genus).
/// NCBI TaxId: 443639
/// </summary>
public abstract class Maulisia : Platytroctidae, IMaulisia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Maulisia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443639;

    /// <inheritdoc />
    public virtual string GenusName => "Maulisia";

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
