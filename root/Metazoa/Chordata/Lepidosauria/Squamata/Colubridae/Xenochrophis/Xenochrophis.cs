using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Xenochrophis;

/// <summary>
/// Abstract class for Xenochrophis (genus).
/// NCBI TaxId: 186567
/// </summary>
public abstract class Xenochrophis : Colubridae, IXenochrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenochrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186567;

    /// <inheritdoc />
    public virtual string GenusName => "Xenochrophis";

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
