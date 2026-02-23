using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Advenus;

/// <summary>
/// Abstract class for Advenus (genus).
/// NCBI TaxId: 3148920
/// </summary>
public abstract class Advenus : Diploglossidae, IAdvenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Advenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148920;

    /// <inheritdoc />
    public virtual string GenusName => "Advenus";

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
