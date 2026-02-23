using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eligmodontia;

/// <summary>
/// Abstract class for Eligmodontia (genus).
/// NCBI TaxId: 56220
/// </summary>
public abstract class Eligmodontia : Cricetidae, IEligmodontia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eligmodontia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56220;

    /// <inheritdoc />
    public virtual string GenusName => "Eligmodontia";

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
