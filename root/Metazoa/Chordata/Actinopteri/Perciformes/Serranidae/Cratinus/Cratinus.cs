using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Cratinus;

/// <summary>
/// Abstract class for Cratinus (genus).
/// NCBI TaxId: 184432
/// </summary>
public abstract class Cratinus : Serranidae, ICratinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cratinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184432;

    /// <inheritdoc />
    public virtual string GenusName => "Cratinus";

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
