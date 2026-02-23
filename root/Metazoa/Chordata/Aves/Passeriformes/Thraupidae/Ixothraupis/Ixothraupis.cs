using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Ixothraupis;

/// <summary>
/// Abstract class for Ixothraupis (genus).
/// NCBI TaxId: 2817425
/// </summary>
public abstract class Ixothraupis : Thraupidae, IIxothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ixothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817425;

    /// <inheritdoc />
    public virtual string GenusName => "Ixothraupis";

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
