using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Alepocephalus;

/// <summary>
/// Abstract class for Alepocephalus (genus).
/// NCBI TaxId: 134617
/// </summary>
public abstract class Alepocephalus : Alepocephalidae, IAlepocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alepocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 134617;

    /// <inheritdoc />
    public virtual string GenusName => "Alepocephalus";

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
