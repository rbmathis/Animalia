using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Solomys;

/// <summary>
/// Abstract class for Solomys (genus).
/// NCBI TaxId: 442620
/// </summary>
public abstract class Solomys : Muridae, ISolomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Solomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442620;

    /// <inheritdoc />
    public virtual string GenusName => "Solomys";

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
