using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Namaquacypris;

/// <summary>
/// Abstract class for Namaquacypris (genus).
/// NCBI TaxId: 3363443
/// </summary>
public abstract class Namaquacypris : Cyprinidae, INamaquacypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Namaquacypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363443;

    /// <inheritdoc />
    public virtual string GenusName => "Namaquacypris";

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
