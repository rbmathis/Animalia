using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Porphyrospiza;

/// <summary>
/// Abstract class for Porphyrospiza (genus).
/// NCBI TaxId: 460184
/// </summary>
public abstract class Porphyrospiza : Thraupidae, IPorphyrospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porphyrospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460184;

    /// <inheritdoc />
    public virtual string GenusName => "Porphyrospiza";

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
