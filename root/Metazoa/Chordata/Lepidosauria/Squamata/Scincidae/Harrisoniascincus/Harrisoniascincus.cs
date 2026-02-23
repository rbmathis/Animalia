using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Harrisoniascincus;

/// <summary>
/// Abstract class for Harrisoniascincus (genus).
/// NCBI TaxId: 1387547
/// </summary>
public abstract class Harrisoniascincus : Scincidae, IHarrisoniascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harrisoniascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1387547;

    /// <inheritdoc />
    public virtual string GenusName => "Harrisoniascincus";

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
