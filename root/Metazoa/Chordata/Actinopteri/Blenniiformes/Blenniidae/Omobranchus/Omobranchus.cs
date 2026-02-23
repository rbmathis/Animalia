using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Omobranchus;

/// <summary>
/// Abstract class for Omobranchus (genus).
/// NCBI TaxId: 57834
/// </summary>
public abstract class Omobranchus : Blenniidae, IOmobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Omobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57834;

    /// <inheritdoc />
    public virtual string GenusName => "Omobranchus";

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
