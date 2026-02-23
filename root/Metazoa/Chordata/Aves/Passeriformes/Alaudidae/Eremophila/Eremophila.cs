using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Eremophila;

/// <summary>
/// Abstract class for Eremophila (genus).
/// NCBI TaxId: 135429
/// </summary>
public abstract class Eremophila : Alaudidae, IEremophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135429;

    /// <inheritdoc />
    public virtual string GenusName => "Eremophila";

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
