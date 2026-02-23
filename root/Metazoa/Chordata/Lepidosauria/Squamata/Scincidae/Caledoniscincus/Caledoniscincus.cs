using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Caledoniscincus;

/// <summary>
/// Abstract class for Caledoniscincus (genus).
/// NCBI TaxId: 394113
/// </summary>
public abstract class Caledoniscincus : Scincidae, ICaledoniscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caledoniscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394113;

    /// <inheritdoc />
    public virtual string GenusName => "Caledoniscincus";

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
