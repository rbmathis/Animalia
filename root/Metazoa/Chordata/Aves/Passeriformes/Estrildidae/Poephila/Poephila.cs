using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Poephila;

/// <summary>
/// Abstract class for Poephila (genus).
/// NCBI TaxId: 40586
/// </summary>
public abstract class Poephila : Estrildidae, IPoephila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poephila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 40586;

    /// <inheritdoc />
    public virtual string GenusName => "Poephila";

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
