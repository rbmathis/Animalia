using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Lycodes;

/// <summary>
/// Abstract class for Lycodes (genus).
/// NCBI TaxId: 8196
/// </summary>
public abstract class Lycodes : Zoarcidae, ILycodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8196;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodes";

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
