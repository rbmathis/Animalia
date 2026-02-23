using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Neochmia;

/// <summary>
/// Abstract class for Neochmia (genus).
/// NCBI TaxId: 247734
/// </summary>
public abstract class Neochmia : Estrildidae, INeochmia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochmia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247734;

    /// <inheritdoc />
    public virtual string GenusName => "Neochmia";

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
