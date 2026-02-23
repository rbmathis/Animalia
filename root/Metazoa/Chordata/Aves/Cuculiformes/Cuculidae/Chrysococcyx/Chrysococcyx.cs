using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Chrysococcyx;

/// <summary>
/// Abstract class for Chrysococcyx (genus).
/// NCBI TaxId: 55666
/// </summary>
public abstract class Chrysococcyx : Cuculidae, IChrysococcyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysococcyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55666;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysococcyx";

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
