using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Epthianura;

/// <summary>
/// Abstract class for Epthianura (genus).
/// NCBI TaxId: 266350
/// </summary>
public abstract class Epthianura : Meliphagidae, IEpthianura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epthianura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266350;

    /// <inheritdoc />
    public virtual string GenusName => "Epthianura";

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
