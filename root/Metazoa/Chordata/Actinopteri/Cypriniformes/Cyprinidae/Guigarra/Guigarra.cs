using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Guigarra;

/// <summary>
/// Abstract class for Guigarra (genus).
/// NCBI TaxId: 2957754
/// </summary>
public abstract class Guigarra : Cyprinidae, IGuigarra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guigarra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2957754;

    /// <inheritdoc />
    public virtual string GenusName => "Guigarra";

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
