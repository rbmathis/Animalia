using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodonus;

/// <summary>
/// Abstract class for Lycodonus (genus).
/// NCBI TaxId: 2995747
/// </summary>
public abstract class Lycodonus : Zoarcidae, ILycodonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2995747;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodonus";

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
