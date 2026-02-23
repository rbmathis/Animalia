using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhamnophis;

/// <summary>
/// Abstract class for Rhamnophis (genus).
/// NCBI TaxId: 292846
/// </summary>
public abstract class Rhamnophis : Colubridae, IRhamnophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamnophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292846;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamnophis";

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
