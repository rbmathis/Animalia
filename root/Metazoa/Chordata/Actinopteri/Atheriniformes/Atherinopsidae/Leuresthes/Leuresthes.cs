using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Leuresthes;

/// <summary>
/// Abstract class for Leuresthes (genus).
/// NCBI TaxId: 355513
/// </summary>
public abstract class Leuresthes : Atherinopsidae, ILeuresthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leuresthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355513;

    /// <inheritdoc />
    public virtual string GenusName => "Leuresthes";

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
