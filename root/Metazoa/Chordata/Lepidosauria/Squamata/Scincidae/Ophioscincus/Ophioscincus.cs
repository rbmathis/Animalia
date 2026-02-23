using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ophioscincus;

/// <summary>
/// Abstract class for Ophioscincus (genus).
/// NCBI TaxId: 220789
/// </summary>
public abstract class Ophioscincus : Scincidae, IOphioscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophioscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220789;

    /// <inheritdoc />
    public virtual string GenusName => "Ophioscincus";

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
