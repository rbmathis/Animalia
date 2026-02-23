using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Hemithraupis;

/// <summary>
/// Abstract class for Hemithraupis (genus).
/// NCBI TaxId: 62204
/// </summary>
public abstract class Hemithraupis : Thraupidae, IHemithraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemithraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62204;

    /// <inheritdoc />
    public virtual string GenusName => "Hemithraupis";

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
