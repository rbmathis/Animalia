using AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Trionyx;

/// <summary>
/// Abstract class for Trionyx (genus).
/// NCBI TaxId: 13734
/// </summary>
public abstract class Trionyx : Trionychidae, ITrionyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trionyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13734;

    /// <inheritdoc />
    public virtual string GenusName => "Trionyx";

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
