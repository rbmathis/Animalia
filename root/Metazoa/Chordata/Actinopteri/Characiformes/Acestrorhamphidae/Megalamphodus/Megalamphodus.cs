using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Megalamphodus;

/// <summary>
/// Abstract class for Megalamphodus (genus).
/// NCBI TaxId: 272058
/// </summary>
public abstract class Megalamphodus : Acestrorhamphidae, IMegalamphodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megalamphodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 272058;

    /// <inheritdoc />
    public virtual string GenusName => "Megalamphodus";

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
