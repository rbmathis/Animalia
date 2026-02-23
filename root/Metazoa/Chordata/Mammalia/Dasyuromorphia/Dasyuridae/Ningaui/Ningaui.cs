using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Ningaui;

/// <summary>
/// Abstract class for Ningaui (genus).
/// NCBI TaxId: 32552
/// </summary>
public abstract class Ningaui : Dasyuridae, INingaui
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ningaui";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32552;

    /// <inheritdoc />
    public virtual string GenusName => "Ningaui";

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
