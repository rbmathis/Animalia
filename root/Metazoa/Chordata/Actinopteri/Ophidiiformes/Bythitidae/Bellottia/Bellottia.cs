using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Bellottia;

/// <summary>
/// Abstract class for Bellottia (genus).
/// NCBI TaxId: 1843759
/// </summary>
public abstract class Bellottia : Bythitidae, IBellottia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bellottia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1843759;

    /// <inheritdoc />
    public virtual string GenusName => "Bellottia";

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
