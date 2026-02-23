using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hydrochous;

/// <summary>
/// Abstract class for Hydrochous (genus).
/// NCBI TaxId: 46501
/// </summary>
public abstract class Hydrochous : Apodidae, IHydrochous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrochous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46501;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrochous";

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
