using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Spiloptila;

/// <summary>
/// Abstract class for Spiloptila (genus).
/// NCBI TaxId: 330754
/// </summary>
public abstract class Spiloptila : Cisticolidae, ISpiloptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spiloptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330754;

    /// <inheritdoc />
    public virtual string GenusName => "Spiloptila";

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
