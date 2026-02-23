using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Paraleptomys;

/// <summary>
/// Abstract class for Paraleptomys (genus).
/// NCBI TaxId: 1795552
/// </summary>
public abstract class Paraleptomys : Muridae, IParaleptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraleptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1795552;

    /// <inheritdoc />
    public virtual string GenusName => "Paraleptomys";

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
