using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Phyllanthus;

/// <summary>
/// Abstract class for Phyllanthus (genus).
/// NCBI TaxId: 634324
/// </summary>
public abstract class Phyllanthus : Leiothrichidae, IPhyllanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634324;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllanthus";

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
