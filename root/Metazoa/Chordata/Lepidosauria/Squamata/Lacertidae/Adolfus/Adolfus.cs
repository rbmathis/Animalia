using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Adolfus;

/// <summary>
/// Abstract class for Adolfus (genus).
/// NCBI TaxId: 80445
/// </summary>
public abstract class Adolfus : Lacertidae, IAdolfus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Adolfus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80445;

    /// <inheritdoc />
    public virtual string GenusName => "Adolfus";

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
