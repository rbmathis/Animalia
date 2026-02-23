using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Lepidonotothen;

/// <summary>
/// Abstract class for Lepidonotothen (genus).
/// NCBI TaxId: 83202
/// </summary>
public abstract class Lepidonotothen : Nototheniidae, ILepidonotothen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidonotothen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83202;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidonotothen";

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
