using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Urothraupis;

/// <summary>
/// Abstract class for Urothraupis (genus).
/// NCBI TaxId: 1226243
/// </summary>
public abstract class Urothraupis : Thraupidae, IUrothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226243;

    /// <inheritdoc />
    public virtual string GenusName => "Urothraupis";

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
