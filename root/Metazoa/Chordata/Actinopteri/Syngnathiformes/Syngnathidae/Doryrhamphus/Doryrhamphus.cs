using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Doryrhamphus;

/// <summary>
/// Abstract class for Doryrhamphus (genus).
/// NCBI TaxId: 161449
/// </summary>
public abstract class Doryrhamphus : Syngnathidae, IDoryrhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doryrhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161449;

    /// <inheritdoc />
    public virtual string GenusName => "Doryrhamphus";

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
