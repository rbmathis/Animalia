using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Taunayia;

/// <summary>
/// Abstract class for Taunayia (genus).
/// NCBI TaxId: 756485
/// </summary>
public abstract class Taunayia : Heptapteridae, ITaunayia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taunayia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 756485;

    /// <inheritdoc />
    public virtual string GenusName => "Taunayia";

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
