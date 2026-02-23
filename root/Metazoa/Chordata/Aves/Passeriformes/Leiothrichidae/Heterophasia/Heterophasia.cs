using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Heterophasia;

/// <summary>
/// Abstract class for Heterophasia (genus).
/// NCBI TaxId: 201325
/// </summary>
public abstract class Heterophasia : Leiothrichidae, IHeterophasia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterophasia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201325;

    /// <inheritdoc />
    public virtual string GenusName => "Heterophasia";

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
