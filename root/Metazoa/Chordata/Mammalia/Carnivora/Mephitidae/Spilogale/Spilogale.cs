using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mephitidae.Spilogale;

/// <summary>
/// Abstract class for Spilogale (genus).
/// NCBI TaxId: 30550
/// </summary>
public abstract class Spilogale : Mephitidae, ISpilogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spilogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30550;

    /// <inheritdoc />
    public virtual string GenusName => "Spilogale";

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
