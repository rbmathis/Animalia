using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

/// <summary>
/// Abstract class for Parotomys (genus).
/// NCBI TaxId: 121577
/// </summary>
public abstract class Parotomys : Muridae, IParotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parotomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121577;

    /// <inheritdoc />
    public virtual string GenusName => "Parotomys";

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
