using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Hologerrhum;

/// <summary>
/// Abstract class for Hologerrhum (genus).
/// NCBI TaxId: 1544989
/// </summary>
public abstract class Hologerrhum : Cyclocoridae, IHologerrhum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hologerrhum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1544989;

    /// <inheritdoc />
    public virtual string GenusName => "Hologerrhum";

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
