using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ateleopodiformes.Ateleopodidae.Ijimaia;

/// <summary>
/// Abstract class for Ijimaia (genus).
/// NCBI TaxId: 178223
/// </summary>
public abstract class Ijimaia : Ateleopodidae, IIjimaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ijimaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 178223;

    /// <inheritdoc />
    public virtual string GenusName => "Ijimaia";

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
