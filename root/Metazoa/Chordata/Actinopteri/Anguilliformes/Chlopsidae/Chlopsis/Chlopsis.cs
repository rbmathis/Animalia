using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Chlopsidae.Chlopsis;

/// <summary>
/// Abstract class for Chlopsis (genus).
/// NCBI TaxId: 722518
/// </summary>
public abstract class Chlopsis : Chlopsidae, IChlopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722518;

    /// <inheritdoc />
    public virtual string GenusName => "Chlopsis";

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
