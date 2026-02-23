using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Coereba;

/// <summary>
/// Abstract class for Coereba (genus).
/// NCBI TaxId: 87176
/// </summary>
public abstract class Coereba : Thraupidae, ICoereba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coereba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87176;

    /// <inheritdoc />
    public virtual string GenusName => "Coereba";

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
