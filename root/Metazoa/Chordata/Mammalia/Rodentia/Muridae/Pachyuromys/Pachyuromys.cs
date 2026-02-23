using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pachyuromys;

/// <summary>
/// Abstract class for Pachyuromys (genus).
/// NCBI TaxId: 298893
/// </summary>
public abstract class Pachyuromys : Muridae, IPachyuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 298893;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyuromys";

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
