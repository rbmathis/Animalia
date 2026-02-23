using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Hirundo;

/// <summary>
/// Abstract class for Hirundo (genus).
/// NCBI TaxId: 43149
/// </summary>
public abstract class Hirundo : Hirundinidae, IHirundo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hirundo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43149;

    /// <inheritdoc />
    public virtual string GenusName => "Hirundo";

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
