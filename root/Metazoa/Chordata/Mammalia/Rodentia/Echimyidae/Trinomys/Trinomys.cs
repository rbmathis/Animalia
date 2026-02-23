using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Trinomys;

/// <summary>
/// Abstract class for Trinomys (genus).
/// NCBI TaxId: 42826
/// </summary>
public abstract class Trinomys : Echimyidae, ITrinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42826;

    /// <inheritdoc />
    public virtual string GenusName => "Trinomys";

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
