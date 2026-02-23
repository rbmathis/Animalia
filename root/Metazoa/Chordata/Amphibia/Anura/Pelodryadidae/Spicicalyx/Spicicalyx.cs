using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Spicicalyx;

/// <summary>
/// Abstract class for Spicicalyx (genus).
/// NCBI TaxId: 3681009
/// </summary>
public abstract class Spicicalyx : Pelodryadidae, ISpicicalyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spicicalyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681009;

    /// <inheritdoc />
    public virtual string GenusName => "Spicicalyx";

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
