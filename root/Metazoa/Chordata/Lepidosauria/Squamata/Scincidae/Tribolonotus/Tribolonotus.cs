using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tribolonotus;

/// <summary>
/// Abstract class for Tribolonotus (genus).
/// NCBI TaxId: 220769
/// </summary>
public abstract class Tribolonotus : Scincidae, ITribolonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tribolonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220769;

    /// <inheritdoc />
    public virtual string GenusName => "Tribolonotus";

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
