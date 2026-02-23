using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Icelinus;

/// <summary>
/// Abstract class for Icelinus (genus).
/// NCBI TaxId: 274761
/// </summary>
public abstract class Icelinus : Cottidae, IIcelinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Icelinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274761;

    /// <inheritdoc />
    public virtual string GenusName => "Icelinus";

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
