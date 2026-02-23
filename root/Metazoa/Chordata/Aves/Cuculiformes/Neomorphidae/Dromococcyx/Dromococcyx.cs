using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Neomorphidae.Dromococcyx;

/// <summary>
/// Abstract class for Dromococcyx (genus).
/// NCBI TaxId: 78205
/// </summary>
public abstract class Dromococcyx : Neomorphidae, IDromococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 78205;

    /// <inheritdoc />
    public virtual string GenusName => "Dromococcyx";

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
