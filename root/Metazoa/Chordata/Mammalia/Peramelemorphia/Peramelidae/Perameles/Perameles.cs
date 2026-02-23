using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Peramelemorphia.Peramelidae.Perameles;

/// <summary>
/// Abstract class for Perameles (genus).
/// NCBI TaxId: 9343
/// </summary>
public abstract class Perameles : Peramelidae, IPerameles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perameles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9343;

    /// <inheritdoc />
    public virtual string GenusName => "Perameles";

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
