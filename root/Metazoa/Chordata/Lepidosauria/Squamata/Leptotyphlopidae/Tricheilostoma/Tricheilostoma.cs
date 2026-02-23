using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leptotyphlopidae.Tricheilostoma;

/// <summary>
/// Abstract class for Tricheilostoma (genus).
/// NCBI TaxId: 711341
/// </summary>
public abstract class Tricheilostoma : Leptotyphlopidae, ITricheilostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tricheilostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 711341;

    /// <inheritdoc />
    public virtual string GenusName => "Tricheilostoma";

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
