using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Barkudia;

/// <summary>
/// Abstract class for Barkudia (genus).
/// NCBI TaxId: 1540810
/// </summary>
public abstract class Barkudia : Scincidae, IBarkudia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barkudia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1540810;

    /// <inheritdoc />
    public virtual string GenusName => "Barkudia";

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
