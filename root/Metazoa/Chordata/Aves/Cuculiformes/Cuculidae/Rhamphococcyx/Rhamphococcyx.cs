using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Rhamphococcyx;

/// <summary>
/// Abstract class for Rhamphococcyx (genus).
/// NCBI TaxId: 3054338
/// </summary>
public abstract class Rhamphococcyx : Cuculidae, IRhamphococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3054338;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphococcyx";

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
