using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Silybura;

/// <summary>
/// Abstract class for Silybura (genus).
/// NCBI TaxId: 2820094
/// </summary>
public abstract class Silybura : Uropeltidae, ISilybura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Silybura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2820094;

    /// <inheritdoc />
    public virtual string GenusName => "Silybura";

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
