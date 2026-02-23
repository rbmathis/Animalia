using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Hylocichla;

/// <summary>
/// Abstract class for Hylocichla (genus).
/// NCBI TaxId: 172419
/// </summary>
public abstract class Hylocichla : Turdidae, IHylocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172419;

    /// <inheritdoc />
    public virtual string GenusName => "Hylocichla";

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
