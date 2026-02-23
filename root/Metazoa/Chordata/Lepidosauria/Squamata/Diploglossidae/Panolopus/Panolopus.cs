using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Panolopus;

/// <summary>
/// Abstract class for Panolopus (genus).
/// NCBI TaxId: 2839125
/// </summary>
public abstract class Panolopus : Diploglossidae, IPanolopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Panolopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2839125;

    /// <inheritdoc />
    public virtual string GenusName => "Panolopus";

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
