using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Uropeltidae.Plectrurus;

/// <summary>
/// Abstract class for Plectrurus (genus).
/// NCBI TaxId: 1545383
/// </summary>
public abstract class Plectrurus : Uropeltidae, IPlectrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plectrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545383;

    /// <inheritdoc />
    public virtual string GenusName => "Plectrurus";

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
