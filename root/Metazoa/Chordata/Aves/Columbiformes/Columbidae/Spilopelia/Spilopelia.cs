using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Spilopelia;

/// <summary>
/// Abstract class for Spilopelia (genus).
/// NCBI TaxId: 2823198
/// </summary>
public abstract class Spilopelia : Columbidae, ISpilopelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spilopelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2823198;

    /// <inheritdoc />
    public virtual string GenusName => "Spilopelia";

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
