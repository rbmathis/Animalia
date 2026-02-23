using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Chaetomys;

/// <summary>
/// Abstract class for Chaetomys (genus).
/// NCBI TaxId: 480663
/// </summary>
public abstract class Chaetomys : Erethizontidae, IChaetomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 480663;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetomys";

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
