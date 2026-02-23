using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Pontinus;

/// <summary>
/// Abstract class for Pontinus (genus).
/// NCBI TaxId: 72111
/// </summary>
public abstract class Pontinus : Scorpaenidae, IPontinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pontinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72111;

    /// <inheritdoc />
    public virtual string GenusName => "Pontinus";

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
