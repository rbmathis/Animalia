using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pseudocolopteryx;

/// <summary>
/// Abstract class for Pseudocolopteryx (genus).
/// NCBI TaxId: 478638
/// </summary>
public abstract class Pseudocolopteryx : Tyrannidae, IPseudocolopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocolopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478638;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocolopteryx";

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
