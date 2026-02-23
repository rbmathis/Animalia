using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Iomys;

/// <summary>
/// Abstract class for Iomys (genus).
/// NCBI TaxId: 226812
/// </summary>
public abstract class Iomys : Sciuridae, IIomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226812;

    /// <inheritdoc />
    public virtual string GenusName => "Iomys";

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
