using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenopsis;

/// <summary>
/// Abstract class for Scorpaenopsis (genus).
/// NCBI TaxId: 163119
/// </summary>
public abstract class Scorpaenopsis : Scorpaenidae, IScorpaenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpaenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163119;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpaenopsis";

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
