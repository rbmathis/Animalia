using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Peristediidae.Scalicus;

/// <summary>
/// Abstract class for Scalicus (genus).
/// NCBI TaxId: 990922
/// </summary>
public abstract class Scalicus : Peristediidae, IScalicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scalicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990922;

    /// <inheritdoc />
    public virtual string GenusName => "Scalicus";

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
