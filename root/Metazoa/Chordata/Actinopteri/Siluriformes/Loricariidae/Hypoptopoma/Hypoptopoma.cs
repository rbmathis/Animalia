using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hypoptopoma;

/// <summary>
/// Abstract class for Hypoptopoma (genus).
/// NCBI TaxId: 321125
/// </summary>
public abstract class Hypoptopoma : Loricariidae, IHypoptopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypoptopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321125;

    /// <inheritdoc />
    public virtual string GenusName => "Hypoptopoma";

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
