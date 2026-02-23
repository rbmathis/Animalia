using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Xenojulis;

/// <summary>
/// Abstract class for Xenojulis (genus).
/// NCBI TaxId: 1984850
/// </summary>
public abstract class Xenojulis : Labridae, IXenojulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenojulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1984850;

    /// <inheritdoc />
    public virtual string GenusName => "Xenojulis";

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
