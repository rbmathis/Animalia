using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Mimoblennius;

/// <summary>
/// Abstract class for Mimoblennius (genus).
/// NCBI TaxId: 2100437
/// </summary>
public abstract class Mimoblennius : Blenniidae, IMimoblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mimoblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2100437;

    /// <inheritdoc />
    public virtual string GenusName => "Mimoblennius";

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
