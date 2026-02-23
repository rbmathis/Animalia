using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Podomys;

/// <summary>
/// Abstract class for Podomys (genus).
/// NCBI TaxId: 56322
/// </summary>
public abstract class Podomys : Cricetidae, IPodomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56322;

    /// <inheritdoc />
    public virtual string GenusName => "Podomys";

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
