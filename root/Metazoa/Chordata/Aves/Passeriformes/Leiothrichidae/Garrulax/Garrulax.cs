using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Garrulax;

/// <summary>
/// Abstract class for Garrulax (genus).
/// NCBI TaxId: 98126
/// </summary>
public abstract class Garrulax : Leiothrichidae, IGarrulax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Garrulax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98126;

    /// <inheritdoc />
    public virtual string GenusName => "Garrulax";

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
