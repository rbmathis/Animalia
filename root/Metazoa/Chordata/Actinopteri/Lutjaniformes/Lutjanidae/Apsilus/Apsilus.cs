using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Apsilus;

/// <summary>
/// Abstract class for Apsilus (genus).
/// NCBI TaxId: 546539
/// </summary>
public abstract class Apsilus : Lutjanidae, IApsilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apsilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 546539;

    /// <inheritdoc />
    public virtual string GenusName => "Apsilus";

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
