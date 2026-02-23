using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Hypsoblennius;

/// <summary>
/// Abstract class for Hypsoblennius (genus).
/// NCBI TaxId: 57810
/// </summary>
public abstract class Hypsoblennius : Blenniidae, IHypsoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57810;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsoblennius";

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
