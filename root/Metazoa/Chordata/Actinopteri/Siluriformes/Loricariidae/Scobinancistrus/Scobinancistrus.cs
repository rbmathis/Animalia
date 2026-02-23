using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Scobinancistrus;

/// <summary>
/// Abstract class for Scobinancistrus (genus).
/// NCBI TaxId: 281740
/// </summary>
public abstract class Scobinancistrus : Loricariidae, IScobinancistrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scobinancistrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 281740;

    /// <inheritdoc />
    public virtual string GenusName => "Scobinancistrus";

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
