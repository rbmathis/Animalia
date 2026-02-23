using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Tropidoscincus;

/// <summary>
/// Abstract class for Tropidoscincus (genus).
/// NCBI TaxId: 394175
/// </summary>
public abstract class Tropidoscincus : Scincidae, ITropidoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394175;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidoscincus";

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
