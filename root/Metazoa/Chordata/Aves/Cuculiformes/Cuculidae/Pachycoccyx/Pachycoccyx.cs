using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Pachycoccyx;

/// <summary>
/// Abstract class for Pachycoccyx (genus).
/// NCBI TaxId: 2817427
/// </summary>
public abstract class Pachycoccyx : Cuculidae, IPachycoccyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachycoccyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817427;

    /// <inheritdoc />
    public virtual string GenusName => "Pachycoccyx";

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
