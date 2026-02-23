using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Tscherskia;

/// <summary>
/// Abstract class for Tscherskia (genus).
/// NCBI TaxId: 329626
/// </summary>
public abstract class Tscherskia : Cricetidae, ITscherskia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tscherskia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329626;

    /// <inheritdoc />
    public virtual string GenusName => "Tscherskia";

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
