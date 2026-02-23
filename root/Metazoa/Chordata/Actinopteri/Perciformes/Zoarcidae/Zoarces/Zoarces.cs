using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Zoarces;

/// <summary>
/// Abstract class for Zoarces (genus).
/// NCBI TaxId: 48415
/// </summary>
public abstract class Zoarces : Zoarcidae, IZoarces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoarces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48415;

    /// <inheritdoc />
    public virtual string GenusName => "Zoarces";

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
