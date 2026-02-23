using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Symbolophorus;

/// <summary>
/// Abstract class for Symbolophorus (genus).
/// NCBI TaxId: 123338
/// </summary>
public abstract class Symbolophorus : Myctophidae, ISymbolophorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Symbolophorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 123338;

    /// <inheritdoc />
    public virtual string GenusName => "Symbolophorus";

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
