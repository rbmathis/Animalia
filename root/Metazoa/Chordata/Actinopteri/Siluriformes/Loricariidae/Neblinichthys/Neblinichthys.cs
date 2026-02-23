using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Neblinichthys;

/// <summary>
/// Abstract class for Neblinichthys (genus).
/// NCBI TaxId: 1633189
/// </summary>
public abstract class Neblinichthys : Loricariidae, INeblinichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neblinichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633189;

    /// <inheritdoc />
    public virtual string GenusName => "Neblinichthys";

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
