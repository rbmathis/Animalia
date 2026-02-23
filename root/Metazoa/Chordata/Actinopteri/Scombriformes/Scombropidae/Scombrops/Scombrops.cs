using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Scombropidae.Scombrops;

/// <summary>
/// Abstract class for Scombrops (genus).
/// NCBI TaxId: 433666
/// </summary>
public abstract class Scombrops : Scombropidae, IScombrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scombrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 433666;

    /// <inheritdoc />
    public virtual string GenusName => "Scombrops";

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
