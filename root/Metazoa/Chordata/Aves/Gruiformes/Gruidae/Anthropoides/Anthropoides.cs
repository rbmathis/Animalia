using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Gruidae.Anthropoides;

/// <summary>
/// Abstract class for Anthropoides (genus).
/// NCBI TaxId: 1171716
/// </summary>
public abstract class Anthropoides : Gruidae, IAnthropoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthropoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1171716;

    /// <inheritdoc />
    public virtual string GenusName => "Anthropoides";

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
