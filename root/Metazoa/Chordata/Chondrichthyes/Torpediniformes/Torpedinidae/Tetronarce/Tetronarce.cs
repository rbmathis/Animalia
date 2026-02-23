using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Tetronarce;

/// <summary>
/// Abstract class for Tetronarce (genus).
/// NCBI TaxId: 1804737
/// </summary>
public abstract class Tetronarce : Torpedinidae, ITetronarce
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetronarce";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1804737;

    /// <inheritdoc />
    public virtual string GenusName => "Tetronarce";

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
