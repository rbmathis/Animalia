using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Brunhilda;

/// <summary>
/// Abstract class for Brunhilda (genus).
/// NCBI TaxId: 2821131
/// </summary>
public abstract class Brunhilda : Estrildidae, IBrunhilda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brunhilda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821131;

    /// <inheritdoc />
    public virtual string GenusName => "Brunhilda";

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
