using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Phaeoscincus;

/// <summary>
/// Abstract class for Phaeoscincus (genus).
/// NCBI TaxId: 2051856
/// </summary>
public abstract class Phaeoscincus : Scincidae, IPhaeoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phaeoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2051856;

    /// <inheritdoc />
    public virtual string GenusName => "Phaeoscincus";

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
