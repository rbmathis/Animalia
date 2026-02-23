using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gerrhosauridae.Broadleysaurus;

/// <summary>
/// Abstract class for Broadleysaurus (genus).
/// NCBI TaxId: 1444760
/// </summary>
public abstract class Broadleysaurus : Gerrhosauridae, IBroadleysaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Broadleysaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1444760;

    /// <inheritdoc />
    public virtual string GenusName => "Broadleysaurus";

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
