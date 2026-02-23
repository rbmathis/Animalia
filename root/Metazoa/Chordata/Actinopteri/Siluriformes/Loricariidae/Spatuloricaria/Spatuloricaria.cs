using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Spatuloricaria;

/// <summary>
/// Abstract class for Spatuloricaria (genus).
/// NCBI TaxId: 337697
/// </summary>
public abstract class Spatuloricaria : Loricariidae, ISpatuloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spatuloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337697;

    /// <inheritdoc />
    public virtual string GenusName => "Spatuloricaria";

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
