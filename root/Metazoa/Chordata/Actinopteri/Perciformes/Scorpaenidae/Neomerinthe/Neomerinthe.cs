using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Neomerinthe;

/// <summary>
/// Abstract class for Neomerinthe (genus).
/// NCBI TaxId: 399149
/// </summary>
public abstract class Neomerinthe : Scorpaenidae, INeomerinthe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomerinthe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399149;

    /// <inheritdoc />
    public virtual string GenusName => "Neomerinthe";

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
