using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Diploglossus;

/// <summary>
/// Abstract class for Diploglossus (genus).
/// NCBI TaxId: 102181
/// </summary>
public abstract class Diploglossus : Diploglossidae, IDiploglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diploglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 102181;

    /// <inheritdoc />
    public virtual string GenusName => "Diploglossus";

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
