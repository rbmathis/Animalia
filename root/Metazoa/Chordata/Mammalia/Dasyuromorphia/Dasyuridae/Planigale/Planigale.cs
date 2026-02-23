using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Planigale;

/// <summary>
/// Abstract class for Planigale (genus).
/// NCBI TaxId: 9296
/// </summary>
public abstract class Planigale : Dasyuridae, IPlanigale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Planigale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9296;

    /// <inheritdoc />
    public virtual string GenusName => "Planigale";

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
