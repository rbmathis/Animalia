using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricaria;

/// <summary>
/// Abstract class for Loricaria (genus).
/// NCBI TaxId: 52085
/// </summary>
public abstract class Loricaria : Loricariidae, ILoricaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loricaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52085;

    /// <inheritdoc />
    public virtual string GenusName => "Loricaria";

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
