using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Engraulicypris;

/// <summary>
/// Abstract class for Engraulicypris (genus).
/// NCBI TaxId: 1108575
/// </summary>
public abstract class Engraulicypris : Danionidae, IEngraulicypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Engraulicypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108575;

    /// <inheritdoc />
    public virtual string GenusName => "Engraulicypris";

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
