using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tachymenoides;

/// <summary>
/// Abstract class for Tachymenoides (genus).
/// NCBI TaxId: 2982190
/// </summary>
public abstract class Tachymenoides : Dipsadidae, ITachymenoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachymenoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2982190;

    /// <inheritdoc />
    public virtual string GenusName => "Tachymenoides";

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
