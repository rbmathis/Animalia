using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaenodes;

/// <summary>
/// Abstract class for Scorpaenodes (genus).
/// NCBI TaxId: 274701
/// </summary>
public abstract class Scorpaenodes : Scorpaenidae, IScorpaenodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpaenodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274701;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpaenodes";

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
