using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Helogale;

/// <summary>
/// Abstract class for Helogale (genus).
/// NCBI TaxId: 210645
/// </summary>
public abstract class Helogale : Herpestidae, IHelogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210645;

    /// <inheritdoc />
    public virtual string GenusName => "Helogale";

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
