using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Nucras;

/// <summary>
/// Abstract class for Nucras (genus).
/// NCBI TaxId: 80453
/// </summary>
public abstract class Nucras : Lacertidae, INucras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nucras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80453;

    /// <inheritdoc />
    public virtual string GenusName => "Nucras";

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
