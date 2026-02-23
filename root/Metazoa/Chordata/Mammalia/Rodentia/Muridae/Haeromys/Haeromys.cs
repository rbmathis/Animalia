using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Haeromys;

/// <summary>
/// Abstract class for Haeromys (genus).
/// NCBI TaxId: 2683854
/// </summary>
public abstract class Haeromys : Muridae, IHaeromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haeromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2683854;

    /// <inheritdoc />
    public virtual string GenusName => "Haeromys";

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
