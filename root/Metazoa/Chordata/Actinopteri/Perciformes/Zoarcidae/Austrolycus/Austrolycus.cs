using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Austrolycus;

/// <summary>
/// Abstract class for Austrolycus (genus).
/// NCBI TaxId: 56728
/// </summary>
public abstract class Austrolycus : Zoarcidae, IAustrolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56728;

    /// <inheritdoc />
    public virtual string GenusName => "Austrolycus";

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
