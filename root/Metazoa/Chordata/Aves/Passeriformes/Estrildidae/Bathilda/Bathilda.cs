using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Bathilda;

/// <summary>
/// Abstract class for Bathilda (genus).
/// NCBI TaxId: 2821129
/// </summary>
public abstract class Bathilda : Estrildidae, IBathilda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathilda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821129;

    /// <inheritdoc />
    public virtual string GenusName => "Bathilda";

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
