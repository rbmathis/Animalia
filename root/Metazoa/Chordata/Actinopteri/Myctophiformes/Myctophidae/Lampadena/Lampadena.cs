using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Lampadena;

/// <summary>
/// Abstract class for Lampadena (genus).
/// NCBI TaxId: 123246
/// </summary>
public abstract class Lampadena : Myctophidae, ILampadena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lampadena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123246;

    /// <inheritdoc />
    public virtual string GenusName => "Lampadena";

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
