using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Conothraupis;

/// <summary>
/// Abstract class for Conothraupis (genus).
/// NCBI TaxId: 62180
/// </summary>
public abstract class Conothraupis : Thraupidae, IConothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62180;

    /// <inheritdoc />
    public virtual string GenusName => "Conothraupis";

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
