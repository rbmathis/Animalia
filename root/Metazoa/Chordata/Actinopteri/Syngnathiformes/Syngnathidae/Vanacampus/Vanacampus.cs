using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Vanacampus;

/// <summary>
/// Abstract class for Vanacampus (genus).
/// NCBI TaxId: 161595
/// </summary>
public abstract class Vanacampus : Syngnathidae, IVanacampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vanacampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161595;

    /// <inheritdoc />
    public virtual string GenusName => "Vanacampus";

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
