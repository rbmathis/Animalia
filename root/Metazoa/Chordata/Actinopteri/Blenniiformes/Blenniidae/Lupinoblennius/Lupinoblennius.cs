using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Lupinoblennius;

/// <summary>
/// Abstract class for Lupinoblennius (genus).
/// NCBI TaxId: 2856765
/// </summary>
public abstract class Lupinoblennius : Blenniidae, ILupinoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lupinoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2856765;

    /// <inheritdoc />
    public virtual string GenusName => "Lupinoblennius";

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
