using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Searsia;

/// <summary>
/// Abstract class for Searsia (genus).
/// NCBI TaxId: 473384
/// </summary>
public abstract class Searsia : Platytroctidae, ISearsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Searsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473384;

    /// <inheritdoc />
    public virtual string GenusName => "Searsia";

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
