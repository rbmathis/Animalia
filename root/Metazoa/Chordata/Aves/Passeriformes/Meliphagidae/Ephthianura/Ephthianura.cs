using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Ephthianura;

/// <summary>
/// Abstract class for Ephthianura (genus).
/// NCBI TaxId: 254532
/// </summary>
public abstract class Ephthianura : Meliphagidae, IEphthianura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ephthianura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254532;

    /// <inheritdoc />
    public virtual string GenusName => "Ephthianura";

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
