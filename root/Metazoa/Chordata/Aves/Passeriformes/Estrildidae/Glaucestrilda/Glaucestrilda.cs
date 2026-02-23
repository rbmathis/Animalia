using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Glaucestrilda;

/// <summary>
/// Abstract class for Glaucestrilda (genus).
/// NCBI TaxId: 2821652
/// </summary>
public abstract class Glaucestrilda : Estrildidae, IGlaucestrilda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucestrilda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821652;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucestrilda";

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
