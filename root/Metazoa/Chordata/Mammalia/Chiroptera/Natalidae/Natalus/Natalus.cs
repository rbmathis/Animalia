using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Natalus;

/// <summary>
/// Abstract class for Natalus (genus).
/// NCBI TaxId: 59486
/// </summary>
public abstract class Natalus : Natalidae, INatalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Natalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59486;

    /// <inheritdoc />
    public virtual string GenusName => "Natalus";

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
