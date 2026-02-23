using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Lamprospiza;

/// <summary>
/// Abstract class for Lamprospiza (genus).
/// NCBI TaxId: 62214
/// </summary>
public abstract class Lamprospiza : Thraupidae, ILamprospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lamprospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62214;

    /// <inheritdoc />
    public virtual string GenusName => "Lamprospiza";

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
