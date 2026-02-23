using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Parmoptila;

/// <summary>
/// Abstract class for Parmoptila (genus).
/// NCBI TaxId: 208081
/// </summary>
public abstract class Parmoptila : Estrildidae, IParmoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parmoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208081;

    /// <inheritdoc />
    public virtual string GenusName => "Parmoptila";

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
