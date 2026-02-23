using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Drymoreomys;

/// <summary>
/// Abstract class for Drymoreomys (genus).
/// NCBI TaxId: 948927
/// </summary>
public abstract class Drymoreomys : Cricetidae, IDrymoreomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymoreomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948927;

    /// <inheritdoc />
    public virtual string GenusName => "Drymoreomys";

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
