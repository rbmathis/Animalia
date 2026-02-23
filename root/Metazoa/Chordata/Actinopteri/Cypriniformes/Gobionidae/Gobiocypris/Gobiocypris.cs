using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Gobiocypris;

/// <summary>
/// Abstract class for Gobiocypris (genus).
/// NCBI TaxId: 143605
/// </summary>
public abstract class Gobiocypris : Gobionidae, IGobiocypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gobiocypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143605;

    /// <inheritdoc />
    public virtual string GenusName => "Gobiocypris";

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
