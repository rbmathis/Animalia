using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Melanodera;

/// <summary>
/// Abstract class for Melanodera (genus).
/// NCBI TaxId: 548486
/// </summary>
public abstract class Melanodera : Thraupidae, IMelanodera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanodera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 548486;

    /// <inheritdoc />
    public virtual string GenusName => "Melanodera";

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
