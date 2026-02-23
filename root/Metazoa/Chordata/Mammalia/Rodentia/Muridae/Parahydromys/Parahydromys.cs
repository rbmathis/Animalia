using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parahydromys;

/// <summary>
/// Abstract class for Parahydromys (genus).
/// NCBI TaxId: 442591
/// </summary>
public abstract class Parahydromys : Muridae, IParahydromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parahydromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442591;

    /// <inheritdoc />
    public virtual string GenusName => "Parahydromys";

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
