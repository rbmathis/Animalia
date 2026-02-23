using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.Dugongidae.Dugong;

/// <summary>
/// Abstract class for Dugong (genus).
/// NCBI TaxId: 29136
/// </summary>
public abstract class Dugong : Dugongidae, IDugong
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dugong";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29136;

    /// <inheritdoc />
    public virtual string GenusName => "Dugong";

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
