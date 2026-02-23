using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Scopelopsis;

/// <summary>
/// Abstract class for Scopelopsis (genus).
/// NCBI TaxId: 123326
/// </summary>
public abstract class Scopelopsis : Myctophidae, IScopelopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scopelopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123326;

    /// <inheritdoc />
    public virtual string GenusName => "Scopelopsis";

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
