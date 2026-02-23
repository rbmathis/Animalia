using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Garra;

/// <summary>
/// Abstract class for Garra (genus).
/// NCBI TaxId: 137059
/// </summary>
public abstract class Garra : Cyprinidae, IGarra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137059;

    /// <inheritdoc />
    public virtual string GenusName => "Garra";

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
