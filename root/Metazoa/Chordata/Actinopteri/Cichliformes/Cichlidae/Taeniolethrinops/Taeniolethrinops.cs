using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Taeniolethrinops;

/// <summary>
/// Abstract class for Taeniolethrinops (genus).
/// NCBI TaxId: 163643
/// </summary>
public abstract class Taeniolethrinops : Cichlidae, ITaeniolethrinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniolethrinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 163643;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniolethrinops";

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
