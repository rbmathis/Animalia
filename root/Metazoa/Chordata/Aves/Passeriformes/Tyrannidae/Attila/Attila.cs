using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Attila;

/// <summary>
/// Abstract class for Attila (genus).
/// NCBI TaxId: 478620
/// </summary>
public abstract class Attila : Tyrannidae, IAttila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Attila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478620;

    /// <inheritdoc />
    public virtual string GenusName => "Attila";

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
