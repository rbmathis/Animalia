using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leptomys;

/// <summary>
/// Abstract class for Leptomys (genus).
/// NCBI TaxId: 442571
/// </summary>
public abstract class Leptomys : Muridae, ILeptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442571;

    /// <inheritdoc />
    public virtual string GenusName => "Leptomys";

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
