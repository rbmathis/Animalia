using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Gymnasio;

/// <summary>
/// Abstract class for Gymnasio (genus).
/// NCBI TaxId: 3150831
/// </summary>
public abstract class Gymnasio : Strigidae, IGymnasio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnasio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150831;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnasio";

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
