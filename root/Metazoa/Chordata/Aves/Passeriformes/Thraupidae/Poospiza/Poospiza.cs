using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Poospiza;

/// <summary>
/// Abstract class for Poospiza (genus).
/// NCBI TaxId: 136968
/// </summary>
public abstract class Poospiza : Thraupidae, IPoospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 136968;

    /// <inheritdoc />
    public virtual string GenusName => "Poospiza";

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
