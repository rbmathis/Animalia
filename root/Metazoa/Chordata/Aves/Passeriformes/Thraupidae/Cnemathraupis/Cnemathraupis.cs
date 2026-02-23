using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Cnemathraupis;

/// <summary>
/// Abstract class for Cnemathraupis (genus).
/// NCBI TaxId: 3150841
/// </summary>
public abstract class Cnemathraupis : Thraupidae, ICnemathraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemathraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150841;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemathraupis";

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
