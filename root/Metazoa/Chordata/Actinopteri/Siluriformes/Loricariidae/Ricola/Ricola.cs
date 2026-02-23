using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Ricola;

/// <summary>
/// Abstract class for Ricola (genus).
/// NCBI TaxId: 3137437
/// </summary>
public abstract class Ricola : Loricariidae, IRicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ricola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3137437;

    /// <inheritdoc />
    public virtual string GenusName => "Ricola";

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
