using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Cosmocampus;

/// <summary>
/// Abstract class for Cosmocampus (genus).
/// NCBI TaxId: 587045
/// </summary>
public abstract class Cosmocampus : Syngnathidae, ICosmocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cosmocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587045;

    /// <inheritdoc />
    public virtual string GenusName => "Cosmocampus";

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
