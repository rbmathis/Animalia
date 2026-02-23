using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Curculionichthys;

/// <summary>
/// Abstract class for Curculionichthys (genus).
/// NCBI TaxId: 2479416
/// </summary>
public abstract class Curculionichthys : Loricariidae, ICurculionichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Curculionichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2479416;

    /// <inheritdoc />
    public virtual string GenusName => "Curculionichthys";

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
