using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Paraloricaria;

/// <summary>
/// Abstract class for Paraloricaria (genus).
/// NCBI TaxId: 1748036
/// </summary>
public abstract class Paraloricaria : Loricariidae, IParaloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1748036;

    /// <inheritdoc />
    public virtual string GenusName => "Paraloricaria";

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
