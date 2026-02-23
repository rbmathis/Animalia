using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ornithuroscincus;

/// <summary>
/// Abstract class for Ornithuroscincus (genus).
/// NCBI TaxId: 2878432
/// </summary>
public abstract class Ornithuroscincus : Scincidae, IOrnithuroscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ornithuroscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878432;

    /// <inheritdoc />
    public virtual string GenusName => "Ornithuroscincus";

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
