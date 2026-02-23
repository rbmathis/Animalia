using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Hygophum;

/// <summary>
/// Abstract class for Hygophum (genus).
/// NCBI TaxId: 81365
/// </summary>
public abstract class Hygophum : Myctophidae, IHygophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hygophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81365;

    /// <inheritdoc />
    public virtual string GenusName => "Hygophum";

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
