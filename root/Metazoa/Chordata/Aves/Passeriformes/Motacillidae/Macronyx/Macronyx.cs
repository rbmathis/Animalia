using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Macronyx;

/// <summary>
/// Abstract class for Macronyx (genus).
/// NCBI TaxId: 228278
/// </summary>
public abstract class Macronyx : Motacillidae, IMacronyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macronyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 228278;

    /// <inheritdoc />
    public virtual string GenusName => "Macronyx";

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
