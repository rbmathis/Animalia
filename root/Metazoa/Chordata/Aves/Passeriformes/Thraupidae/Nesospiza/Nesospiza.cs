using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Nesospiza;

/// <summary>
/// Abstract class for Nesospiza (genus).
/// NCBI TaxId: 381880
/// </summary>
public abstract class Nesospiza : Thraupidae, INesospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381880;

    /// <inheritdoc />
    public virtual string GenusName => "Nesospiza";

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
