using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Tribonyx;

/// <summary>
/// Abstract class for Tribonyx (genus).
/// NCBI TaxId: 2861763
/// </summary>
public abstract class Tribonyx : Rallidae, ITribonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tribonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861763;

    /// <inheritdoc />
    public virtual string GenusName => "Tribonyx";

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
