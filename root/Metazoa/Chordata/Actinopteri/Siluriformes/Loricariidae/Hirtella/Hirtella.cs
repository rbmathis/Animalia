using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hirtella;

/// <summary>
/// Abstract class for Hirtella (genus).
/// NCBI TaxId: 1912254
/// </summary>
public abstract class Hirtella : Loricariidae, IHirtella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hirtella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1912254;

    /// <inheritdoc />
    public virtual string GenusName => "Hirtella";

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
