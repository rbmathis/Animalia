using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Planiloricaria;

/// <summary>
/// Abstract class for Planiloricaria (genus).
/// NCBI TaxId: 503160
/// </summary>
public abstract class Planiloricaria : Loricariidae, IPlaniloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Planiloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503160;

    /// <inheritdoc />
    public virtual string GenusName => "Planiloricaria";

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
