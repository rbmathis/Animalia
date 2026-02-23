using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Procypris;

/// <summary>
/// Abstract class for Procypris (genus).
/// NCBI TaxId: 367865
/// </summary>
public abstract class Procypris : Cyprinidae, IProcypris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procypris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 367865;

    /// <inheritdoc />
    public virtual string GenusName => "Procypris";

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
