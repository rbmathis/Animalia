using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Inlecypris;

/// <summary>
/// Abstract class for Inlecypris (genus).
/// NCBI TaxId: 1906846
/// </summary>
public abstract class Inlecypris : Danionidae, IInlecypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Inlecypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1906846;

    /// <inheritdoc />
    public virtual string GenusName => "Inlecypris";

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
