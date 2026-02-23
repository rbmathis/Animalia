using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Brachypteryx;

/// <summary>
/// Abstract class for Brachypteryx (genus).
/// NCBI TaxId: 757450
/// </summary>
public abstract class Brachypteryx : Muscicapidae, IBrachypteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachypteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 757450;

    /// <inheritdoc />
    public virtual string GenusName => "Brachypteryx";

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
