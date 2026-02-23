using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Dephomys;

/// <summary>
/// Abstract class for Dephomys (genus).
/// NCBI TaxId: 1001552
/// </summary>
public abstract class Dephomys : Muridae, IDephomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dephomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1001552;

    /// <inheritdoc />
    public virtual string GenusName => "Dephomys";

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
