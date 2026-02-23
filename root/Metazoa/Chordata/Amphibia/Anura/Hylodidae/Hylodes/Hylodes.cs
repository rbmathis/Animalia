using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylodidae.Hylodes;

/// <summary>
/// Abstract class for Hylodes (genus).
/// NCBI TaxId: 209659
/// </summary>
public abstract class Hylodes : Hylodidae, IHylodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209659;

    /// <inheritdoc />
    public virtual string GenusName => "Hylodes";

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
