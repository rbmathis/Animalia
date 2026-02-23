using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Kleinothraupis;

/// <summary>
/// Abstract class for Kleinothraupis (genus).
/// NCBI TaxId: 3150842
/// </summary>
public abstract class Kleinothraupis : Thraupidae, IKleinothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kleinothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150842;

    /// <inheritdoc />
    public virtual string GenusName => "Kleinothraupis";

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
