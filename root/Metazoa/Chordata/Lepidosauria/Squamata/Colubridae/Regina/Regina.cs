using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Regina;

/// <summary>
/// Abstract class for Regina (genus).
/// NCBI TaxId: 183601
/// </summary>
public abstract class Regina : Colubridae, IRegina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Regina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183601;

    /// <inheritdoc />
    public virtual string GenusName => "Regina";

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
