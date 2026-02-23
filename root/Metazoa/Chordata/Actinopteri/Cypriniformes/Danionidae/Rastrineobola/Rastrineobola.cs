using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rastrineobola;

/// <summary>
/// Abstract class for Rastrineobola (genus).
/// NCBI TaxId: 1108696
/// </summary>
public abstract class Rastrineobola : Danionidae, IRastrineobola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rastrineobola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108696;

    /// <inheritdoc />
    public virtual string GenusName => "Rastrineobola";

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
