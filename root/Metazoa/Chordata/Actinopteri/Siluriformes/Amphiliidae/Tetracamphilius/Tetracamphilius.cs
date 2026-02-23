using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Tetracamphilius;

/// <summary>
/// Abstract class for Tetracamphilius (genus).
/// NCBI TaxId: 1233699
/// </summary>
public abstract class Tetracamphilius : Amphiliidae, ITetracamphilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetracamphilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233699;

    /// <inheritdoc />
    public virtual string GenusName => "Tetracamphilius";

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
