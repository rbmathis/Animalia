using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Bathytroctes;

/// <summary>
/// Abstract class for Bathytroctes (genus).
/// NCBI TaxId: 443632
/// </summary>
public abstract class Bathytroctes : Alepocephalidae, IBathytroctes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathytroctes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443632;

    /// <inheritdoc />
    public virtual string GenusName => "Bathytroctes";

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
