using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Riopa;

/// <summary>
/// Abstract class for Riopa (genus).
/// NCBI TaxId: 2571104
/// </summary>
public abstract class Riopa : Scincidae, IRiopa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Riopa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2571104;

    /// <inheritdoc />
    public virtual string GenusName => "Riopa";

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
