using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Scorpaena;

/// <summary>
/// Abstract class for Scorpaena (genus).
/// NCBI TaxId: 72113
/// </summary>
public abstract class Scorpaena : Scorpaenidae, IScorpaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scorpaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72113;

    /// <inheritdoc />
    public virtual string GenusName => "Scorpaena";

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
