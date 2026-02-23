using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Cylix;

/// <summary>
/// Abstract class for Cylix (genus).
/// NCBI TaxId: 2986464
/// </summary>
public abstract class Cylix : Syngnathidae, ICylix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cylix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986464;

    /// <inheritdoc />
    public virtual string GenusName => "Cylix";

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
