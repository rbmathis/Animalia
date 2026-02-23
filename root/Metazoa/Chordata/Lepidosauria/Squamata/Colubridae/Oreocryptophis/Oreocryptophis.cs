using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oreocryptophis;

/// <summary>
/// Abstract class for Oreocryptophis (genus).
/// NCBI TaxId: 341695
/// </summary>
public abstract class Oreocryptophis : Colubridae, IOreocryptophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreocryptophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 341695;

    /// <inheritdoc />
    public virtual string GenusName => "Oreocryptophis";

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
