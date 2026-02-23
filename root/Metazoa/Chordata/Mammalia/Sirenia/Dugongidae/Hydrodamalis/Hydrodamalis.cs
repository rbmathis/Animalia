using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae.Hydrodamalis;

/// <summary>
/// Abstract class for Hydrodamalis (genus).
/// NCBI TaxId: 63630
/// </summary>
public abstract class Hydrodamalis : Dugongidae, IHydrodamalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrodamalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63630;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrodamalis";

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
