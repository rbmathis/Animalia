using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Scincus;

/// <summary>
/// Abstract class for Scincus (genus).
/// NCBI TaxId: 155316
/// </summary>
public abstract class Scincus : Scincidae, IScincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 155316;

    /// <inheritdoc />
    public virtual string GenusName => "Scincus";

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
