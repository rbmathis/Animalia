using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Tolypeutes;

/// <summary>
/// Abstract class for Tolypeutes (genus).
/// NCBI TaxId: 183748
/// </summary>
public abstract class Tolypeutes : Chlamyphoridae, ITolypeutes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tolypeutes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183748;

    /// <inheritdoc />
    public virtual string GenusName => "Tolypeutes";

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
