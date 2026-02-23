using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Scotopelia;

/// <summary>
/// Abstract class for Scotopelia (genus).
/// NCBI TaxId: 2499928
/// </summary>
public abstract class Scotopelia : Strigidae, IScotopelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotopelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499928;

    /// <inheritdoc />
    public virtual string GenusName => "Scotopelia";

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
