using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Patagonotothen;

/// <summary>
/// Abstract class for Patagonotothen (genus).
/// NCBI TaxId: 83204
/// </summary>
public abstract class Patagonotothen : Nototheniidae, IPatagonotothen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Patagonotothen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83204;

    /// <inheritdoc />
    public virtual string GenusName => "Patagonotothen";

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
