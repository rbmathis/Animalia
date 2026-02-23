using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Palusophis;

/// <summary>
/// Abstract class for Palusophis (genus).
/// NCBI TaxId: 2571427
/// </summary>
public abstract class Palusophis : Colubridae, IPalusophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palusophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2571427;

    /// <inheritdoc />
    public virtual string GenusName => "Palusophis";

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
