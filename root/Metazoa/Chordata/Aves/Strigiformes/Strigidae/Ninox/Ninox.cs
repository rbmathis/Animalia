using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Ninox;

/// <summary>
/// Abstract class for Ninox (genus).
/// NCBI TaxId: 56288
/// </summary>
public abstract class Ninox : Strigidae, INinox
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ninox";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56288;

    /// <inheritdoc />
    public virtual string GenusName => "Ninox";

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
