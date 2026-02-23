using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelabditus;

/// <summary>
/// Abstract class for Pimelabditus (genus).
/// NCBI TaxId: 702662
/// </summary>
public abstract class Pimelabditus : Pimelodidae, IPimelabditus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pimelabditus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 702662;

    /// <inheritdoc />
    public virtual string GenusName => "Pimelabditus";

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
