using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Nesasio;

/// <summary>
/// Abstract class for Nesasio (genus).
/// NCBI TaxId: 2653984
/// </summary>
public abstract class Nesasio : Strigidae, INesasio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesasio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2653984;

    /// <inheritdoc />
    public virtual string GenusName => "Nesasio";

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
