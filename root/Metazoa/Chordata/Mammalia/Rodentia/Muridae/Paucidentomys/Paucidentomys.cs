using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paucidentomys;

/// <summary>
/// Abstract class for Paucidentomys (genus).
/// NCBI TaxId: 1478021
/// </summary>
public abstract class Paucidentomys : Muridae, IPaucidentomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paucidentomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1478021;

    /// <inheritdoc />
    public virtual string GenusName => "Paucidentomys";

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
