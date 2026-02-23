using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Brachiopsilus;

/// <summary>
/// Abstract class for Brachiopsilus (genus).
/// NCBI TaxId: 3119965
/// </summary>
public abstract class Brachiopsilus : Brachionichthyidae, IBrachiopsilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachiopsilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3119965;

    /// <inheritdoc />
    public virtual string GenusName => "Brachiopsilus";

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
