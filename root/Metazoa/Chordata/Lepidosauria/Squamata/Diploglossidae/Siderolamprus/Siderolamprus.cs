using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Siderolamprus;

/// <summary>
/// Abstract class for Siderolamprus (genus).
/// NCBI TaxId: 2839127
/// </summary>
public abstract class Siderolamprus : Diploglossidae, ISiderolamprus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siderolamprus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839127;

    /// <inheritdoc />
    public virtual string GenusName => "Siderolamprus";

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
