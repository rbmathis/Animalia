using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Ochrotomys;

/// <summary>
/// Abstract class for Ochrotomys (genus).
/// NCBI TaxId: 56228
/// </summary>
public abstract class Ochrotomys : Cricetidae, IOchrotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ochrotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56228;

    /// <inheritdoc />
    public virtual string GenusName => "Ochrotomys";

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
