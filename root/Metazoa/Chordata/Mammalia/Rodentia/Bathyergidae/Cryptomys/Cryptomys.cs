using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Cryptomys;

/// <summary>
/// Abstract class for Cryptomys (genus).
/// NCBI TaxId: 10173
/// </summary>
public abstract class Cryptomys : Bathyergidae, ICryptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10173;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptomys";

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
