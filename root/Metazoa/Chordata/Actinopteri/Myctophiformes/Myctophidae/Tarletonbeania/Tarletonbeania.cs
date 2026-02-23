using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Tarletonbeania;

/// <summary>
/// Abstract class for Tarletonbeania (genus).
/// NCBI TaxId: 91659
/// </summary>
public abstract class Tarletonbeania : Myctophidae, ITarletonbeania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tarletonbeania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91659;

    /// <inheritdoc />
    public virtual string GenusName => "Tarletonbeania";

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
