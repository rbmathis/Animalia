using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhipidomys;

/// <summary>
/// Abstract class for Rhipidomys (genus).
/// NCBI TaxId: 29128
/// </summary>
public abstract class Rhipidomys : Cricetidae, IRhipidomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhipidomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29128;

    /// <inheritdoc />
    public virtual string GenusName => "Rhipidomys";

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
