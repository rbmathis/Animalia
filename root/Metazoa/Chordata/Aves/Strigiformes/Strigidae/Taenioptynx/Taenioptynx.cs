using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Taenioptynx;

/// <summary>
/// Abstract class for Taenioptynx (genus).
/// NCBI TaxId: 3150832
/// </summary>
public abstract class Taenioptynx : Strigidae, ITaenioptynx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taenioptynx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150832;

    /// <inheritdoc />
    public virtual string GenusName => "Taenioptynx";

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
