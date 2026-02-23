using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lethrinops;

/// <summary>
/// Abstract class for Lethrinops (genus).
/// NCBI TaxId: 32504
/// </summary>
public abstract class Lethrinops : Cichlidae, ILethrinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lethrinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32504;

    /// <inheritdoc />
    public virtual string GenusName => "Lethrinops";

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
