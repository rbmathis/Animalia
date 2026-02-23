using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Apistoloricaria;

/// <summary>
/// Abstract class for Apistoloricaria (genus).
/// NCBI TaxId: 510786
/// </summary>
public abstract class Apistoloricaria : Loricariidae, IApistoloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apistoloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510786;

    /// <inheritdoc />
    public virtual string GenusName => "Apistoloricaria";

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
