using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Oxygymnocypris;

/// <summary>
/// Abstract class for Oxygymnocypris (genus).
/// NCBI TaxId: 361643
/// </summary>
public abstract class Oxygymnocypris : Cyprinidae, IOxygymnocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxygymnocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 361643;

    /// <inheritdoc />
    public virtual string GenusName => "Oxygymnocypris";

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
