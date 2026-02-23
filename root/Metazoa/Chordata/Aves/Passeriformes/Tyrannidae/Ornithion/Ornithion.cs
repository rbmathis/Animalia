using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Ornithion;

/// <summary>
/// Abstract class for Ornithion (genus).
/// NCBI TaxId: 456403
/// </summary>
public abstract class Ornithion : Tyrannidae, IOrnithion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ornithion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456403;

    /// <inheritdoc />
    public virtual string GenusName => "Ornithion";

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
