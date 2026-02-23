using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cyanoptila;

/// <summary>
/// Abstract class for Cyanoptila (genus).
/// NCBI TaxId: 125285
/// </summary>
public abstract class Cyanoptila : Muscicapidae, ICyanoptila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanoptila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125285;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanoptila";

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
