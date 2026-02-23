using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodus;

/// <summary>
/// Abstract class for Pimelodus (genus).
/// NCBI TaxId: 42504
/// </summary>
public abstract class Pimelodus : Pimelodidae, IPimelodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pimelodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42504;

    /// <inheritdoc />
    public virtual string GenusName => "Pimelodus";

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
