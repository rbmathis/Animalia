using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Atopophrynus;

/// <summary>
/// Abstract class for Atopophrynus (genus).
/// NCBI TaxId: 613038
/// </summary>
public abstract class Atopophrynus : Strabomantidae, IAtopophrynus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atopophrynus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 613038;

    /// <inheritdoc />
    public virtual string GenusName => "Atopophrynus";

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
