using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Diglossa;

/// <summary>
/// Abstract class for Diglossa (genus).
/// NCBI TaxId: 62192
/// </summary>
public abstract class Diglossa : Thraupidae, IDiglossa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diglossa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62192;

    /// <inheritdoc />
    public virtual string GenusName => "Diglossa";

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
