using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Liburnascincus;

/// <summary>
/// Abstract class for Liburnascincus (genus).
/// NCBI TaxId: 1351707
/// </summary>
public abstract class Liburnascincus : Scincidae, ILiburnascincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liburnascincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1351707;

    /// <inheritdoc />
    public virtual string GenusName => "Liburnascincus";

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
