using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Calochaetes;

/// <summary>
/// Abstract class for Calochaetes (genus).
/// NCBI TaxId: 62160
/// </summary>
public abstract class Calochaetes : Thraupidae, ICalochaetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calochaetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62160;

    /// <inheritdoc />
    public virtual string GenusName => "Calochaetes";

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
