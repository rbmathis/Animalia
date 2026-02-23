using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Brochiloricaria;

/// <summary>
/// Abstract class for Brochiloricaria (genus).
/// NCBI TaxId: 1748032
/// </summary>
public abstract class Brochiloricaria : Loricariidae, IBrochiloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brochiloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1748032;

    /// <inheritdoc />
    public virtual string GenusName => "Brochiloricaria";

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
