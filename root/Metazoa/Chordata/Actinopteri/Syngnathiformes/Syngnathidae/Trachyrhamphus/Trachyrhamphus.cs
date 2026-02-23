using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Trachyrhamphus;

/// <summary>
/// Abstract class for Trachyrhamphus (genus).
/// NCBI TaxId: 161593
/// </summary>
public abstract class Trachyrhamphus : Syngnathidae, ITrachyrhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trachyrhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161593;

    /// <inheritdoc />
    public virtual string GenusName => "Trachyrhamphus";

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
