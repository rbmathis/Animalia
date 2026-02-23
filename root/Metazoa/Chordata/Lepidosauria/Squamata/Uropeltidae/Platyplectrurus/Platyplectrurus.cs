using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Platyplectrurus;

/// <summary>
/// Abstract class for Platyplectrurus (genus).
/// NCBI TaxId: 1545381
/// </summary>
public abstract class Platyplectrurus : Uropeltidae, IPlatyplectrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyplectrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545381;

    /// <inheritdoc />
    public virtual string GenusName => "Platyplectrurus";

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
