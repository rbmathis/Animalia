using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Caesio;

/// <summary>
/// Abstract class for Caesio (genus).
/// NCBI TaxId: 119693
/// </summary>
public abstract class Caesio : Lutjanidae, ICaesio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caesio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119693;

    /// <inheritdoc />
    public virtual string GenusName => "Caesio";

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
