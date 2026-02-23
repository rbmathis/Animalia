using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Monticola;

/// <summary>
/// Abstract class for Monticola (genus).
/// NCBI TaxId: 36285
/// </summary>
public abstract class Monticola : Turdidae, IMonticola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monticola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36285;

    /// <inheritdoc />
    public virtual string GenusName => "Monticola";

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
