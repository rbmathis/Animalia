using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Coryphoblennius;

/// <summary>
/// Abstract class for Coryphoblennius (genus).
/// NCBI TaxId: 152537
/// </summary>
public abstract class Coryphoblennius : Blenniidae, ICoryphoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 152537;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphoblennius";

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
