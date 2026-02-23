using AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Musophagiformes.Musophagidae.Tauraco;

/// <summary>
/// Abstract class for Tauraco (genus).
/// NCBI TaxId: 56303
/// </summary>
public abstract class Tauraco : Musophagidae, ITauraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tauraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56303;

    /// <inheritdoc />
    public virtual string GenusName => "Tauraco";

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
