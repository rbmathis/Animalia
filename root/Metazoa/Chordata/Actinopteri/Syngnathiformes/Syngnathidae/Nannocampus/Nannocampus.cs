using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Nannocampus;

/// <summary>
/// Abstract class for Nannocampus (genus).
/// NCBI TaxId: 1914734
/// </summary>
public abstract class Nannocampus : Syngnathidae, INannocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1914734;

    /// <inheritdoc />
    public virtual string GenusName => "Nannocampus";

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
