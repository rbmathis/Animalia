using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bathyaethiops;

/// <summary>
/// Abstract class for Bathyaethiops (genus).
/// NCBI TaxId: 304078
/// </summary>
public abstract class Bathyaethiops : Alestidae, IBathyaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathyaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304078;

    /// <inheritdoc />
    public virtual string GenusName => "Bathyaethiops";

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
