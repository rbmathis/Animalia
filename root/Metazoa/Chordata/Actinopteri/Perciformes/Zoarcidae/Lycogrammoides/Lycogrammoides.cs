using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycogrammoides;

/// <summary>
/// Abstract class for Lycogrammoides (genus).
/// NCBI TaxId: 561517
/// </summary>
public abstract class Lycogrammoides : Zoarcidae, ILycogrammoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycogrammoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 561517;

    /// <inheritdoc />
    public virtual string GenusName => "Lycogrammoides";

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
