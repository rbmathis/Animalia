using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Malayotyphlops;

/// <summary>
/// Abstract class for Malayotyphlops (genus).
/// NCBI TaxId: 1498511
/// </summary>
public abstract class Malayotyphlops : Typhlopidae, IMalayotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malayotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1498511;

    /// <inheritdoc />
    public virtual string GenusName => "Malayotyphlops";

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
