using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Shinisauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Shinisauridae.Shinisaurus;

/// <summary>
/// Abstract class for Shinisaurus (genus).
/// NCBI TaxId: 52223
/// </summary>
public abstract class Shinisaurus : Shinisauridae, IShinisaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Shinisaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52223;

    /// <inheritdoc />
    public virtual string GenusName => "Shinisaurus";

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
