using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.Liopropoma;

/// <summary>
/// Abstract class for Liopropoma (genus).
/// NCBI TaxId: 327789
/// </summary>
public abstract class Liopropoma : Serranidae, ILiopropoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liopropoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327789;

    /// <inheritdoc />
    public virtual string GenusName => "Liopropoma";

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
