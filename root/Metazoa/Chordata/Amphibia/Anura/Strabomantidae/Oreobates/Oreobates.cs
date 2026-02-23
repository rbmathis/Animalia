using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Oreobates;

/// <summary>
/// Abstract class for Oreobates (genus).
/// NCBI TaxId: 449235
/// </summary>
public abstract class Oreobates : Strabomantidae, IOreobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449235;

    /// <inheritdoc />
    public virtual string GenusName => "Oreobates";

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
