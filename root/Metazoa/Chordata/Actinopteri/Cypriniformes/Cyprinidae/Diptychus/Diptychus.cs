using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Diptychus;

/// <summary>
/// Abstract class for Diptychus (genus).
/// NCBI TaxId: 263536
/// </summary>
public abstract class Diptychus : Cyprinidae, IDiptychus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diptychus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263536;

    /// <inheritdoc />
    public virtual string GenusName => "Diptychus";

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
