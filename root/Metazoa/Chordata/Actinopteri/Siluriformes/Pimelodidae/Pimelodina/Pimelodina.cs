using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pimelodina;

/// <summary>
/// Abstract class for Pimelodina (genus).
/// NCBI TaxId: 1150238
/// </summary>
public abstract class Pimelodina : Pimelodidae, IPimelodina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pimelodina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150238;

    /// <inheritdoc />
    public virtual string GenusName => "Pimelodina";

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
