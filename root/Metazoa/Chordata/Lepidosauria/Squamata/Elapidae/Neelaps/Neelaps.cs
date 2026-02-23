using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Neelaps;

/// <summary>
/// Abstract class for Neelaps (genus).
/// NCBI TaxId: 439934
/// </summary>
public abstract class Neelaps : Elapidae, INeelaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neelaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 439934;

    /// <inheritdoc />
    public virtual string GenusName => "Neelaps";

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
