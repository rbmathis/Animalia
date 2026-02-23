using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Parascorpaena;

/// <summary>
/// Abstract class for Parascorpaena (genus).
/// NCBI TaxId: 626228
/// </summary>
public abstract class Parascorpaena : Scorpaenidae, IParascorpaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parascorpaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 626228;

    /// <inheritdoc />
    public virtual string GenusName => "Parascorpaena";

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
