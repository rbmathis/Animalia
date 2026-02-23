using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycozoarces;

/// <summary>
/// Abstract class for Lycozoarces (genus).
/// NCBI TaxId: 641281
/// </summary>
public abstract class Lycozoarces : Zoarcidae, ILycozoarces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycozoarces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641281;

    /// <inheritdoc />
    public virtual string GenusName => "Lycozoarces";

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
