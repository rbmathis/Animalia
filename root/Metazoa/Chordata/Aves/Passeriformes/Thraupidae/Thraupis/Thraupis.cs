using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Thraupis;

/// <summary>
/// Abstract class for Thraupis (genus).
/// NCBI TaxId: 58208
/// </summary>
public abstract class Thraupis : Thraupidae, IThraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58208;

    /// <inheritdoc />
    public virtual string GenusName => "Thraupis";

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
