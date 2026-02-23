using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Makalata;

/// <summary>
/// Abstract class for Makalata (genus).
/// NCBI TaxId: 490305
/// </summary>
public abstract class Makalata : Echimyidae, IMakalata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Makalata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490305;

    /// <inheritdoc />
    public virtual string GenusName => "Makalata";

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
