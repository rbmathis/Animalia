using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Hoplosebastes;

/// <summary>
/// Abstract class for Hoplosebastes (genus).
/// NCBI TaxId: 1609623
/// </summary>
public abstract class Hoplosebastes : Scorpaenidae, IHoplosebastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplosebastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609623;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplosebastes";

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
