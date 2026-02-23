using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Gymnocypris;

/// <summary>
/// Abstract class for Gymnocypris (genus).
/// NCBI TaxId: 75347
/// </summary>
public abstract class Gymnocypris : Cyprinidae, IGymnocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75347;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnocypris";

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
