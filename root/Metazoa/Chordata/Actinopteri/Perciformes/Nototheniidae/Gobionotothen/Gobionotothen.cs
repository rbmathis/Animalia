using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Gobionotothen;

/// <summary>
/// Abstract class for Gobionotothen (genus).
/// NCBI TaxId: 36201
/// </summary>
public abstract class Gobionotothen : Nototheniidae, IGobionotothen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobionotothen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36201;

    /// <inheritdoc />
    public virtual string GenusName => "Gobionotothen";

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
