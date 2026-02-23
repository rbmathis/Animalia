using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Aseraggodes;

/// <summary>
/// Abstract class for Aseraggodes (genus).
/// NCBI TaxId: 195595
/// </summary>
public abstract class Aseraggodes : Soleidae, IAseraggodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aseraggodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195595;

    /// <inheritdoc />
    public virtual string GenusName => "Aseraggodes";

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
