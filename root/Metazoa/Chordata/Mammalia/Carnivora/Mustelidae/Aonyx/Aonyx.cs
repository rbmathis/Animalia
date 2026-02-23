using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Aonyx;

/// <summary>
/// Abstract class for Aonyx (genus).
/// NCBI TaxId: 76721
/// </summary>
public abstract class Aonyx : Mustelidae, IAonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76721;

    /// <inheritdoc />
    public virtual string GenusName => "Aonyx";

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
