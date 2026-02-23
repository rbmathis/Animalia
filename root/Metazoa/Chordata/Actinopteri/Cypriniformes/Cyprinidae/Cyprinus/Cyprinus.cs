using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinus;

/// <summary>
/// Abstract class for Cyprinus (genus).
/// NCBI TaxId: 7961
/// </summary>
public abstract class Cyprinus : Cyprinidae, ICyprinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyprinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7961;

    /// <inheritdoc />
    public virtual string GenusName => "Cyprinus";

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
