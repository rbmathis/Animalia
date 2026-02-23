using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lobulia;

/// <summary>
/// Abstract class for Lobulia (genus).
/// NCBI TaxId: 1545017
/// </summary>
public abstract class Lobulia : Scincidae, ILobulia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lobulia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545017;

    /// <inheritdoc />
    public virtual string GenusName => "Lobulia";

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
