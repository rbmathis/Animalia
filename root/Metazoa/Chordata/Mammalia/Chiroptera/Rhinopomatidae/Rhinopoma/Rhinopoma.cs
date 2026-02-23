using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinopomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinopomatidae.Rhinopoma;

/// <summary>
/// Abstract class for Rhinopoma (genus).
/// NCBI TaxId: 124755
/// </summary>
public abstract class Rhinopoma : Rhinopomatidae, IRhinopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 124755;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinopoma";

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
