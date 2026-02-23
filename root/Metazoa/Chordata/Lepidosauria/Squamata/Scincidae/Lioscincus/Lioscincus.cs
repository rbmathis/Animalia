using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Lioscincus;

/// <summary>
/// Abstract class for Lioscincus (genus).
/// NCBI TaxId: 394133
/// </summary>
public abstract class Lioscincus : Scincidae, ILioscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lioscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 394133;

    /// <inheritdoc />
    public virtual string GenusName => "Lioscincus";

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
