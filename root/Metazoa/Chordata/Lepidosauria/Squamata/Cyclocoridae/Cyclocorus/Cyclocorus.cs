using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Cyclocorus;

/// <summary>
/// Abstract class for Cyclocorus (genus).
/// NCBI TaxId: 1544553
/// </summary>
public abstract class Cyclocorus : Cyclocoridae, ICyclocorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyclocorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544553;

    /// <inheritdoc />
    public virtual string GenusName => "Cyclocorus";

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
