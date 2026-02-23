using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Pygomeles;

/// <summary>
/// Abstract class for Pygomeles (genus).
/// NCBI TaxId: 143639
/// </summary>
public abstract class Pygomeles : Scincidae, IPygomeles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pygomeles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143639;

    /// <inheritdoc />
    public virtual string GenusName => "Pygomeles";

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
