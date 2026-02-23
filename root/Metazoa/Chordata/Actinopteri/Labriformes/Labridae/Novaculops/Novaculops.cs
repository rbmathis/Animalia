using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Novaculops;

/// <summary>
/// Abstract class for Novaculops (genus).
/// NCBI TaxId: 1517489
/// </summary>
public abstract class Novaculops : Labridae, INovaculops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Novaculops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517489;

    /// <inheritdoc />
    public virtual string GenusName => "Novaculops";

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
