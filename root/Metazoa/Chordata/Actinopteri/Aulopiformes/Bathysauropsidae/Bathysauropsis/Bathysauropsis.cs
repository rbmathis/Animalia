using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauropsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Bathysauropsidae.Bathysauropsis;

/// <summary>
/// Abstract class for Bathysauropsis (genus).
/// NCBI TaxId: 2696650
/// </summary>
public abstract class Bathysauropsis : Bathysauropsidae, IBathysauropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathysauropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696650;

    /// <inheritdoc />
    public virtual string GenusName => "Bathysauropsis";

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
