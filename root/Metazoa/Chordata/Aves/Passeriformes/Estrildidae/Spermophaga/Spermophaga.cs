using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Spermophaga;

/// <summary>
/// Abstract class for Spermophaga (genus).
/// NCBI TaxId: 247674
/// </summary>
public abstract class Spermophaga : Estrildidae, ISpermophaga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spermophaga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247674;

    /// <inheritdoc />
    public virtual string GenusName => "Spermophaga";

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
