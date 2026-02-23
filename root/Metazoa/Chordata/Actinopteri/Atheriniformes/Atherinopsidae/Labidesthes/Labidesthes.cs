using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinopsidae.Labidesthes;

/// <summary>
/// Abstract class for Labidesthes (genus).
/// NCBI TaxId: 300303
/// </summary>
public abstract class Labidesthes : Atherinopsidae, ILabidesthes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labidesthes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300303;

    /// <inheritdoc />
    public virtual string GenusName => "Labidesthes";

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
