using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Atherinopsis;

/// <summary>
/// Abstract class for Atherinopsis (genus).
/// NCBI TaxId: 1311531
/// </summary>
public abstract class Atherinopsis : Atherinopsidae, IAtherinopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311531;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinopsis";

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
