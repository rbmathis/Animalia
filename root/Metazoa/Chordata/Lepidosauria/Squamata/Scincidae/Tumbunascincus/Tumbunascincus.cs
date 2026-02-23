using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tumbunascincus;

/// <summary>
/// Abstract class for Tumbunascincus (genus).
/// NCBI TaxId: 1540148
/// </summary>
public abstract class Tumbunascincus : Scincidae, ITumbunascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tumbunascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540148;

    /// <inheritdoc />
    public virtual string GenusName => "Tumbunascincus";

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
