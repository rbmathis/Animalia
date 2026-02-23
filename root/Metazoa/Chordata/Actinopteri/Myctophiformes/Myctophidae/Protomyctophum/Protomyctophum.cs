using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Protomyctophum;

/// <summary>
/// Abstract class for Protomyctophum (genus).
/// NCBI TaxId: 91655
/// </summary>
public abstract class Protomyctophum : Myctophidae, IProtomyctophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Protomyctophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91655;

    /// <inheritdoc />
    public virtual string GenusName => "Protomyctophum";

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
