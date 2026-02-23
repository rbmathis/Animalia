using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Sauresia;

/// <summary>
/// Abstract class for Sauresia (genus).
/// NCBI TaxId: 3136126
/// </summary>
public abstract class Sauresia : Diploglossidae, ISauresia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sauresia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136126;

    /// <inheritdoc />
    public virtual string GenusName => "Sauresia";

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
