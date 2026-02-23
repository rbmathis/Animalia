using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Hakaria;

/// <summary>
/// Abstract class for Hakaria (genus).
/// NCBI TaxId: 246128
/// </summary>
public abstract class Hakaria : Scincidae, IHakaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hakaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 246128;

    /// <inheritdoc />
    public virtual string GenusName => "Hakaria";

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
