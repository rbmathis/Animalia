using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Celatiscincus;

/// <summary>
/// Abstract class for Celatiscincus (genus).
/// NCBI TaxId: 394859
/// </summary>
public abstract class Celatiscincus : Scincidae, ICelatiscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Celatiscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394859;

    /// <inheritdoc />
    public virtual string GenusName => "Celatiscincus";

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
