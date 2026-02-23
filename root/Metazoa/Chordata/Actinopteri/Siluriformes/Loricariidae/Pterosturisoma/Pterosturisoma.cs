using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pterosturisoma;

/// <summary>
/// Abstract class for Pterosturisoma (genus).
/// NCBI TaxId: 1748039
/// </summary>
public abstract class Pterosturisoma : Loricariidae, IPterosturisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterosturisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1748039;

    /// <inheritdoc />
    public virtual string GenusName => "Pterosturisoma";

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
