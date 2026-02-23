using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crateromys;

/// <summary>
/// Abstract class for Crateromys (genus).
/// NCBI TaxId: 349700
/// </summary>
public abstract class Crateromys : Muridae, ICrateromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crateromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 349700;

    /// <inheritdoc />
    public virtual string GenusName => "Crateromys";

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
