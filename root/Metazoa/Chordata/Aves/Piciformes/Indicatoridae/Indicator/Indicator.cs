using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Abstract class for Indicator (genus).
/// NCBI TaxId: 189528
/// </summary>
public abstract class Indicator : Indicatoridae, IIndicator
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indicator";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189528;

    /// <inheritdoc />
    public virtual string GenusName => "Indicator";

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
