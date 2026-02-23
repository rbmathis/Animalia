using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Sinigarra;

/// <summary>
/// Abstract class for Sinigarra (genus).
/// NCBI TaxId: 1897789
/// </summary>
public abstract class Sinigarra : Cyprinidae, ISinigarra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinigarra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1897789;

    /// <inheritdoc />
    public virtual string GenusName => "Sinigarra";

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
