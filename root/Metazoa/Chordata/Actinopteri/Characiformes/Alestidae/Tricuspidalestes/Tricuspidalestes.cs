using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Tricuspidalestes;

/// <summary>
/// Abstract class for Tricuspidalestes (genus).
/// NCBI TaxId: 1042457
/// </summary>
public abstract class Tricuspidalestes : Alestidae, ITricuspidalestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tricuspidalestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1042457;

    /// <inheritdoc />
    public virtual string GenusName => "Tricuspidalestes";

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
