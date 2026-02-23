using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Pimelodella;

/// <summary>
/// Abstract class for Pimelodella (genus).
/// NCBI TaxId: 71256
/// </summary>
public abstract class Pimelodella : Heptapteridae, IPimelodella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pimelodella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71256;

    /// <inheritdoc />
    public virtual string GenusName => "Pimelodella";

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
