using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Pteroidichthys;

/// <summary>
/// Abstract class for Pteroidichthys (genus).
/// NCBI TaxId: 2291624
/// </summary>
public abstract class Pteroidichthys : Scorpaenidae, IPteroidichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteroidichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2291624;

    /// <inheritdoc />
    public virtual string GenusName => "Pteroidichthys";

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
