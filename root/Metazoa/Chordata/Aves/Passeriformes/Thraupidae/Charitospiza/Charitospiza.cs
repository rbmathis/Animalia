using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Charitospiza;

/// <summary>
/// Abstract class for Charitospiza (genus).
/// NCBI TaxId: 1226227
/// </summary>
public abstract class Charitospiza : Thraupidae, ICharitospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Charitospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1226227;

    /// <inheritdoc />
    public virtual string GenusName => "Charitospiza";

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
