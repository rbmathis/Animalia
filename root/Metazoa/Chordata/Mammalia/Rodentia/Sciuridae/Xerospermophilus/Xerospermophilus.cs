using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Xerospermophilus;

/// <summary>
/// Abstract class for Xerospermophilus (genus).
/// NCBI TaxId: 1141643
/// </summary>
public abstract class Xerospermophilus : Sciuridae, IXerospermophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xerospermophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1141643;

    /// <inheritdoc />
    public virtual string GenusName => "Xerospermophilus";

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
