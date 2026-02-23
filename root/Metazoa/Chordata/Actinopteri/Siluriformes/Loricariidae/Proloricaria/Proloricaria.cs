using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Proloricaria;

/// <summary>
/// Abstract class for Proloricaria (genus).
/// NCBI TaxId: 1123873
/// </summary>
public abstract class Proloricaria : Loricariidae, IProloricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proloricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1123873;

    /// <inheritdoc />
    public virtual string GenusName => "Proloricaria";

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
