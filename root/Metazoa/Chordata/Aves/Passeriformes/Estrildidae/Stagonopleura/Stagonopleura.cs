using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Stagonopleura;

/// <summary>
/// Abstract class for Stagonopleura (genus).
/// NCBI TaxId: 247739
/// </summary>
public abstract class Stagonopleura : Estrildidae, IStagonopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stagonopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247739;

    /// <inheritdoc />
    public virtual string GenusName => "Stagonopleura";

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
