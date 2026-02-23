using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Austrochaperina;

/// <summary>
/// Abstract class for Austrochaperina (genus).
/// NCBI TaxId: 480210
/// </summary>
public abstract class Austrochaperina : Microhylidae, IAustrochaperina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Austrochaperina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 480210;

    /// <inheritdoc />
    public virtual string GenusName => "Austrochaperina";

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
