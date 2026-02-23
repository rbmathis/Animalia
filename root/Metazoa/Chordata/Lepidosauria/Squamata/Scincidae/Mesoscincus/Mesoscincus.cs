using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mesoscincus;

/// <summary>
/// Abstract class for Mesoscincus (genus).
/// NCBI TaxId: 245645
/// </summary>
public abstract class Mesoscincus : Scincidae, IMesoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245645;

    /// <inheritdoc />
    public virtual string GenusName => "Mesoscincus";

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
