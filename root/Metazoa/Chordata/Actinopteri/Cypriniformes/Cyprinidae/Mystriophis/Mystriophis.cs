using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystriophis;

/// <summary>
/// Abstract class for Mystriophis (genus).
/// NCBI TaxId: 3080747
/// </summary>
public abstract class Mystriophis : Cyprinidae, IMystriophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mystriophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3080747;

    /// <inheritdoc />
    public virtual string GenusName => "Mystriophis";

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
