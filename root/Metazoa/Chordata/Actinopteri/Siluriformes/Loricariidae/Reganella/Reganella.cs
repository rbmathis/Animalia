using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Reganella;

/// <summary>
/// Abstract class for Reganella (genus).
/// NCBI TaxId: 2486680
/// </summary>
public abstract class Reganella : Loricariidae, IReganella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reganella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2486680;

    /// <inheritdoc />
    public virtual string GenusName => "Reganella";

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
