using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Corymbophanes;

/// <summary>
/// Abstract class for Corymbophanes (genus).
/// NCBI TaxId: 745511
/// </summary>
public abstract class Corymbophanes : Loricariidae, ICorymbophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corymbophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 745511;

    /// <inheritdoc />
    public virtual string GenusName => "Corymbophanes";

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
