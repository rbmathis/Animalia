using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Pectenocypris;

/// <summary>
/// Abstract class for Pectenocypris (genus).
/// NCBI TaxId: 432423
/// </summary>
public abstract class Pectenocypris : Danionidae, IPectenocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pectenocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 432423;

    /// <inheritdoc />
    public virtual string GenusName => "Pectenocypris";

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
