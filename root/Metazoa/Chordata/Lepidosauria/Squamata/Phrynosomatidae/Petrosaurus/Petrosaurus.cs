using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Petrosaurus;

/// <summary>
/// Abstract class for Petrosaurus (genus).
/// NCBI TaxId: 43605
/// </summary>
public abstract class Petrosaurus : Phrynosomatidae, IPetrosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43605;

    /// <inheritdoc />
    public virtual string GenusName => "Petrosaurus";

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
