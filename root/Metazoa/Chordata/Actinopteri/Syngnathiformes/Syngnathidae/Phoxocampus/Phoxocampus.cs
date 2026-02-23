using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Phoxocampus;

/// <summary>
/// Abstract class for Phoxocampus (genus).
/// NCBI TaxId: 1828471
/// </summary>
public abstract class Phoxocampus : Syngnathidae, IPhoxocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoxocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1828471;

    /// <inheritdoc />
    public virtual string GenusName => "Phoxocampus";

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
