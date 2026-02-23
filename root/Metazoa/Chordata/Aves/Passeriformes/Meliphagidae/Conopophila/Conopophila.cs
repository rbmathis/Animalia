using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Conopophila;

/// <summary>
/// Abstract class for Conopophila (genus).
/// NCBI TaxId: 266345
/// </summary>
public abstract class Conopophila : Meliphagidae, IConopophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conopophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266345;

    /// <inheritdoc />
    public virtual string GenusName => "Conopophila";

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
