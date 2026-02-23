using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Bryx;

/// <summary>
/// Abstract class for Bryx (genus).
/// NCBI TaxId: 722429
/// </summary>
public abstract class Bryx : Syngnathidae, IBryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722429;

    /// <inheritdoc />
    public virtual string GenusName => "Bryx";

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
