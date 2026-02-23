using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Neothraupis;

/// <summary>
/// Abstract class for Neothraupis (genus).
/// NCBI TaxId: 62224
/// </summary>
public abstract class Neothraupis : Thraupidae, INeothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62224;

    /// <inheritdoc />
    public virtual string GenusName => "Neothraupis";

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
