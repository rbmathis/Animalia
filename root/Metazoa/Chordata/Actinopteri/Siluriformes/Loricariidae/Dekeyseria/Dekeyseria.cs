using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Dekeyseria;

/// <summary>
/// Abstract class for Dekeyseria (genus).
/// NCBI TaxId: 337762
/// </summary>
public abstract class Dekeyseria : Loricariidae, IDekeyseria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dekeyseria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337762;

    /// <inheritdoc />
    public virtual string GenusName => "Dekeyseria";

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
