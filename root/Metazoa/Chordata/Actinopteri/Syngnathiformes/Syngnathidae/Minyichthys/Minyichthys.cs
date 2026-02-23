using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Minyichthys;

/// <summary>
/// Abstract class for Minyichthys (genus).
/// NCBI TaxId: 2842188
/// </summary>
public abstract class Minyichthys : Syngnathidae, IMinyichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Minyichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2842188;

    /// <inheritdoc />
    public virtual string GenusName => "Minyichthys";

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
