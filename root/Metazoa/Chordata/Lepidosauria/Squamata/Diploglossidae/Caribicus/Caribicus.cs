using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Caribicus;

/// <summary>
/// Abstract class for Caribicus (genus).
/// NCBI TaxId: 2839106
/// </summary>
public abstract class Caribicus : Diploglossidae, ICaribicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caribicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839106;

    /// <inheritdoc />
    public virtual string GenusName => "Caribicus";

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
