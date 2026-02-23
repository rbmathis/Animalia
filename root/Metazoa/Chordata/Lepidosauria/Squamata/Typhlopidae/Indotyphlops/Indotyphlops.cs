using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Typhlopidae.Indotyphlops;

/// <summary>
/// Abstract class for Indotyphlops (genus).
/// NCBI TaxId: 1498493
/// </summary>
public abstract class Indotyphlops : Typhlopidae, IIndotyphlops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indotyphlops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1498493;

    /// <inheritdoc />
    public virtual string GenusName => "Indotyphlops";

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
