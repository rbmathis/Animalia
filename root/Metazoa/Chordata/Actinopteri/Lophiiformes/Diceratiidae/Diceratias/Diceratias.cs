using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Diceratiidae.Diceratias;

/// <summary>
/// Abstract class for Diceratias (genus).
/// NCBI TaxId: 412634
/// </summary>
public abstract class Diceratias : Diceratiidae, IDiceratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412634;

    /// <inheritdoc />
    public virtual string GenusName => "Diceratias";

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
