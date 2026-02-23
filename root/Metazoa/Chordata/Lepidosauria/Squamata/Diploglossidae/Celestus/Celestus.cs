using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Celestus;

/// <summary>
/// Abstract class for Celestus (genus).
/// NCBI TaxId: 102179
/// </summary>
public abstract class Celestus : Diploglossidae, ICelestus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Celestus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102179;

    /// <inheritdoc />
    public virtual string GenusName => "Celestus";

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
