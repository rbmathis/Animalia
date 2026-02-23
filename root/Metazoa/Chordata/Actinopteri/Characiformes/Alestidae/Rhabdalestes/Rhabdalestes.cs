using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Rhabdalestes;

/// <summary>
/// Abstract class for Rhabdalestes (genus).
/// NCBI TaxId: 206429
/// </summary>
public abstract class Rhabdalestes : Alestidae, IRhabdalestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhabdalestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206429;

    /// <inheritdoc />
    public virtual string GenusName => "Rhabdalestes";

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
