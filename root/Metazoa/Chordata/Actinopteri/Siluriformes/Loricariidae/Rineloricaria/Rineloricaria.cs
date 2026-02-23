using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rineloricaria;

/// <summary>
/// Abstract class for Rineloricaria (genus).
/// NCBI TaxId: 52091
/// </summary>
public abstract class Rineloricaria : Loricariidae, IRineloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rineloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52091;

    /// <inheritdoc />
    public virtual string GenusName => "Rineloricaria";

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
