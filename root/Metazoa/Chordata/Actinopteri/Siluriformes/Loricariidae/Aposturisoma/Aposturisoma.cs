using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Aposturisoma;

/// <summary>
/// Abstract class for Aposturisoma (genus).
/// NCBI TaxId: 1748030
/// </summary>
public abstract class Aposturisoma : Loricariidae, IAposturisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aposturisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1748030;

    /// <inheritdoc />
    public virtual string GenusName => "Aposturisoma";

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
