using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Laniisoma;

/// <summary>
/// Abstract class for Laniisoma (genus).
/// NCBI TaxId: 114308
/// </summary>
public abstract class Laniisoma : Cotingidae, ILaniisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laniisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114308;

    /// <inheritdoc />
    public virtual string GenusName => "Laniisoma";

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
