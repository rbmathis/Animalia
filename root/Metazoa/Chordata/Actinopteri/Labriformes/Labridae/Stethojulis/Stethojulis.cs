using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Stethojulis;

/// <summary>
/// Abstract class for Stethojulis (genus).
/// NCBI TaxId: 241347
/// </summary>
public abstract class Stethojulis : Labridae, IStethojulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stethojulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241347;

    /// <inheritdoc />
    public virtual string GenusName => "Stethojulis";

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
