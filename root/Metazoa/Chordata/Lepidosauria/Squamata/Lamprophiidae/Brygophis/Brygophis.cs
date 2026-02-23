using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Brygophis;

/// <summary>
/// Abstract class for Brygophis (genus).
/// NCBI TaxId: 1543327
/// </summary>
public abstract class Brygophis : Lamprophiidae, IBrygophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brygophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1543327;

    /// <inheritdoc />
    public virtual string GenusName => "Brygophis";

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
