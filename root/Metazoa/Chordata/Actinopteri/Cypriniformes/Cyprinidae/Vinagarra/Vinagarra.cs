using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Vinagarra;

/// <summary>
/// Abstract class for Vinagarra (genus).
/// NCBI TaxId: 2764703
/// </summary>
public abstract class Vinagarra : Cyprinidae, IVinagarra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vinagarra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2764703;

    /// <inheritdoc />
    public virtual string GenusName => "Vinagarra";

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
