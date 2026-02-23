using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Nubeoscincus;

/// <summary>
/// Abstract class for Nubeoscincus (genus).
/// NCBI TaxId: 2878435
/// </summary>
public abstract class Nubeoscincus : Scincidae, INubeoscincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nubeoscincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878435;

    /// <inheritdoc />
    public virtual string GenusName => "Nubeoscincus";

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
