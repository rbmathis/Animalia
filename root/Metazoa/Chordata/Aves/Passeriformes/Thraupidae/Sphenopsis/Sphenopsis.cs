using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Sphenopsis;

/// <summary>
/// Abstract class for Sphenopsis (genus).
/// NCBI TaxId: 3050618
/// </summary>
public abstract class Sphenopsis : Thraupidae, ISphenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3050618;

    /// <inheritdoc />
    public virtual string GenusName => "Sphenopsis";

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
