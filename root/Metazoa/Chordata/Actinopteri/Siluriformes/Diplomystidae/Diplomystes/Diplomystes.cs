using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Diplomystidae.Diplomystes;

/// <summary>
/// Abstract class for Diplomystes (genus).
/// NCBI TaxId: 337531
/// </summary>
public abstract class Diplomystes : Diplomystidae, IDiplomystes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplomystes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337531;

    /// <inheritdoc />
    public virtual string GenusName => "Diplomystes";

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
