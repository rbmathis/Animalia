using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Guentherus;

/// <summary>
/// Abstract class for Guentherus (genus).
/// NCBI TaxId: 1263180
/// </summary>
public abstract class Guentherus : Ateleopodidae, IGuentherus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guentherus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1263180;

    /// <inheritdoc />
    public virtual string GenusName => "Guentherus";

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
