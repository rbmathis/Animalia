using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Mullus;

/// <summary>
/// Abstract class for Mullus (genus).
/// NCBI TaxId: 37006
/// </summary>
public abstract class Mullus : Mullidae, IMullus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mullus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37006;

    /// <inheritdoc />
    public virtual string GenusName => "Mullus";

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
