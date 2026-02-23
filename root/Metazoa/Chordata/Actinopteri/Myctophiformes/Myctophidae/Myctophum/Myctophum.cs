using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Myctophum;

/// <summary>
/// Abstract class for Myctophum (genus).
/// NCBI TaxId: 68516
/// </summary>
public abstract class Myctophum : Myctophidae, IMyctophum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myctophum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68516;

    /// <inheritdoc />
    public virtual string GenusName => "Myctophum";

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
