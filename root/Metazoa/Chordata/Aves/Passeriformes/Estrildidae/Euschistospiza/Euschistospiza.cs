using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Euschistospiza;

/// <summary>
/// Abstract class for Euschistospiza (genus).
/// NCBI TaxId: 247534
/// </summary>
public abstract class Euschistospiza : Estrildidae, IEuschistospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euschistospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247534;

    /// <inheritdoc />
    public virtual string GenusName => "Euschistospiza";

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
