using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tatera;

/// <summary>
/// Abstract class for Tatera (genus).
/// NCBI TaxId: 41262
/// </summary>
public abstract class Tatera : Muridae, ITatera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tatera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 41262;

    /// <inheritdoc />
    public virtual string GenusName => "Tatera";

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
