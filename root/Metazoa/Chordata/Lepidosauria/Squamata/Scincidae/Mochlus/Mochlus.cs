using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mochlus;

/// <summary>
/// Abstract class for Mochlus (genus).
/// NCBI TaxId: 681532
/// </summary>
public abstract class Mochlus : Scincidae, IMochlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mochlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681532;

    /// <inheritdoc />
    public virtual string GenusName => "Mochlus";

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
