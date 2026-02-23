using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Urolestes;

/// <summary>
/// Abstract class for Urolestes (genus).
/// NCBI TaxId: 2954252
/// </summary>
public abstract class Urolestes : Laniidae, IUrolestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urolestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2954252;

    /// <inheritdoc />
    public virtual string GenusName => "Urolestes";

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
