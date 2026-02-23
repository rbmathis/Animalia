using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Nesokia;

/// <summary>
/// Abstract class for Nesokia (genus).
/// NCBI TaxId: 51372
/// </summary>
public abstract class Nesokia : Muridae, INesokia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesokia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51372;

    /// <inheritdoc />
    public virtual string GenusName => "Nesokia";

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
