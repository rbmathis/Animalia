using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Morococcyx;

/// <summary>
/// Abstract class for Morococcyx (genus).
/// NCBI TaxId: 3054334
/// </summary>
public abstract class Morococcyx : Cuculidae, IMorococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Morococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3054334;

    /// <inheritdoc />
    public virtual string GenusName => "Morococcyx";

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
