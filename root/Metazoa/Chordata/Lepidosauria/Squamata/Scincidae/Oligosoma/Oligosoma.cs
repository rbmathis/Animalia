using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Oligosoma;

/// <summary>
/// Abstract class for Oligosoma (genus).
/// NCBI TaxId: 105721
/// </summary>
public abstract class Oligosoma : Scincidae, IOligosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 105721;

    /// <inheritdoc />
    public virtual string GenusName => "Oligosoma";

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
