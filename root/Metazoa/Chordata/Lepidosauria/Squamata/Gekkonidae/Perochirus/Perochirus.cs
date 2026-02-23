using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Perochirus;

/// <summary>
/// Abstract class for Perochirus (genus).
/// NCBI TaxId: 1127069
/// </summary>
public abstract class Perochirus : Gekkonidae, IPerochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1127069;

    /// <inheritdoc />
    public virtual string GenusName => "Perochirus";

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
