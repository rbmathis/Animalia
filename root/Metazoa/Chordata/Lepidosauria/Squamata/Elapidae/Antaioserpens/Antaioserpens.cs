using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Antaioserpens;

/// <summary>
/// Abstract class for Antaioserpens (genus).
/// NCBI TaxId: 1539845
/// </summary>
public abstract class Antaioserpens : Elapidae, IAntaioserpens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antaioserpens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1539845;

    /// <inheritdoc />
    public virtual string GenusName => "Antaioserpens";

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
