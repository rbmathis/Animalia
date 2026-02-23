using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Iodopleura;

/// <summary>
/// Abstract class for Iodopleura (genus).
/// NCBI TaxId: 114306
/// </summary>
public abstract class Iodopleura : Cotingidae, IIodopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iodopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114306;

    /// <inheritdoc />
    public virtual string GenusName => "Iodopleura";

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
