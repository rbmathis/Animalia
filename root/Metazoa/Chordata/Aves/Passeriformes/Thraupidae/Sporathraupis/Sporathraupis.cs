using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Sporathraupis;

/// <summary>
/// Abstract class for Sporathraupis (genus).
/// NCBI TaxId: 3150851
/// </summary>
public abstract class Sporathraupis : Thraupidae, ISporathraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sporathraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150851;

    /// <inheritdoc />
    public virtual string GenusName => "Sporathraupis";

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
