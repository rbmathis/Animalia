using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Epicrates;

/// <summary>
/// Abstract class for Epicrates (genus).
/// NCBI TaxId: 8575
/// </summary>
public abstract class Epicrates : Boidae, IEpicrates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epicrates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8575;

    /// <inheritdoc />
    public virtual string GenusName => "Epicrates";

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
