using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peroryctidae.Rhynchomeles;

/// <summary>
/// Abstract class for Rhynchomeles (genus).
/// NCBI TaxId: 1031280
/// </summary>
public abstract class Rhynchomeles : Peroryctidae, IRhynchomeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchomeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1031280;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchomeles";

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
