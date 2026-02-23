using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Callistomys;

/// <summary>
/// Abstract class for Callistomys (genus).
/// NCBI TaxId: 1567506
/// </summary>
public abstract class Callistomys : Echimyidae, ICallistomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callistomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1567506;

    /// <inheritdoc />
    public virtual string GenusName => "Callistomys";

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
