using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Atherinidae.Atherinomorus;

/// <summary>
/// Abstract class for Atherinomorus (genus).
/// NCBI TaxId: 69129
/// </summary>
public abstract class Atherinomorus : Atherinidae, IAtherinomorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atherinomorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69129;

    /// <inheritdoc />
    public virtual string GenusName => "Atherinomorus";

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
