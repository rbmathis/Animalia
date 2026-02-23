using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Benthosema;

/// <summary>
/// Abstract class for Benthosema (genus).
/// NCBI TaxId: 123334
/// </summary>
public abstract class Benthosema : Myctophidae, IBenthosema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthosema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123334;

    /// <inheritdoc />
    public virtual string GenusName => "Benthosema";

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
