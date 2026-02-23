using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariichthys;

/// <summary>
/// Abstract class for Loricariichthys (genus).
/// NCBI TaxId: 503149
/// </summary>
public abstract class Loricariichthys : Loricariidae, ILoricariichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loricariichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503149;

    /// <inheritdoc />
    public virtual string GenusName => "Loricariichthys";

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
