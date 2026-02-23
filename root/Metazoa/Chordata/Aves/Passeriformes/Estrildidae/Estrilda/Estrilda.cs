using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Estrilda;

/// <summary>
/// Abstract class for Estrilda (genus).
/// NCBI TaxId: 187426
/// </summary>
public abstract class Estrilda : Estrildidae, IEstrilda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Estrilda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187426;

    /// <inheritdoc />
    public virtual string GenusName => "Estrilda";

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
