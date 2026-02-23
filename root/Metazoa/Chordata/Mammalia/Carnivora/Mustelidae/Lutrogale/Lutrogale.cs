using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Lutrogale;

/// <summary>
/// Abstract class for Lutrogale (genus).
/// NCBI TaxId: 452643
/// </summary>
public abstract class Lutrogale : Mustelidae, ILutrogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lutrogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 452643;

    /// <inheritdoc />
    public virtual string GenusName => "Lutrogale";

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
