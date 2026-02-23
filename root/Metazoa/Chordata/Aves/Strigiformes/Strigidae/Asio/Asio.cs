using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Asio;

/// <summary>
/// Abstract class for Asio (genus).
/// NCBI TaxId: 56266
/// </summary>
public abstract class Asio : Strigidae, IAsio
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asio";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56266;

    /// <inheritdoc />
    public virtual string GenusName => "Asio";

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
