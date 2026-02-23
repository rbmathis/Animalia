using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Odacidae.Olisthops;

/// <summary>
/// Abstract class for Olisthops (genus).
/// NCBI TaxId: 1605465
/// </summary>
public abstract class Olisthops : Odacidae, IOlisthops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Olisthops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1605465;

    /// <inheritdoc />
    public virtual string GenusName => "Olisthops";

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
