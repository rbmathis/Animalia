using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Meroles;

/// <summary>
/// Abstract class for Meroles (genus).
/// NCBI TaxId: 71686
/// </summary>
public abstract class Meroles : Lacertidae, IMeroles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meroles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71686;

    /// <inheritdoc />
    public virtual string GenusName => "Meroles";

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
