using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Labracinus;

/// <summary>
/// Abstract class for Labracinus (genus).
/// NCBI TaxId: 270573
/// </summary>
public abstract class Labracinus : Pseudochromidae, ILabracinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labracinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270573;

    /// <inheritdoc />
    public virtual string GenusName => "Labracinus";

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
