using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Psiloscops;

/// <summary>
/// Abstract class for Psiloscops (genus).
/// NCBI TaxId: 507969
/// </summary>
public abstract class Psiloscops : Strigidae, IPsiloscops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psiloscops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 507969;

    /// <inheritdoc />
    public virtual string GenusName => "Psiloscops";

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
