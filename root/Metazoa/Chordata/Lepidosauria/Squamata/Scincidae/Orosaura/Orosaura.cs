using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Orosaura;

/// <summary>
/// Abstract class for Orosaura (genus).
/// NCBI TaxId: 1206297
/// </summary>
public abstract class Orosaura : Scincidae, IOrosaura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Orosaura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206297;

    /// <inheritdoc />
    public virtual string GenusName => "Orosaura";

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
