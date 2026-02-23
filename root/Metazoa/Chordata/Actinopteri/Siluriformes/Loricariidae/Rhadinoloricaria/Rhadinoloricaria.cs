using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Rhadinoloricaria;

/// <summary>
/// Abstract class for Rhadinoloricaria (genus).
/// NCBI TaxId: 1748097
/// </summary>
public abstract class Rhadinoloricaria : Loricariidae, IRhadinoloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhadinoloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1748097;

    /// <inheritdoc />
    public virtual string GenusName => "Rhadinoloricaria";

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
