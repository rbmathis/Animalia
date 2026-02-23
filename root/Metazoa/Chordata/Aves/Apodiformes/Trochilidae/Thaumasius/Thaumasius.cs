using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Thaumasius;

/// <summary>
/// Abstract class for Thaumasius (genus).
/// NCBI TaxId: 3150860
/// </summary>
public abstract class Thaumasius : Trochilidae, IThaumasius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thaumasius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150860;

    /// <inheritdoc />
    public virtual string GenusName => "Thaumasius";

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
