using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Gliciphila;

/// <summary>
/// Abstract class for Gliciphila (genus).
/// NCBI TaxId: 2821653
/// </summary>
public abstract class Gliciphila : Meliphagidae, IGliciphila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gliciphila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821653;

    /// <inheritdoc />
    public virtual string GenusName => "Gliciphila";

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
