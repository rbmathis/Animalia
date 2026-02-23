using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Antennablennius;

/// <summary>
/// Abstract class for Antennablennius (genus).
/// NCBI TaxId: 990928
/// </summary>
public abstract class Antennablennius : Blenniidae, IAntennablennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antennablennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990928;

    /// <inheritdoc />
    public virtual string GenusName => "Antennablennius";

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
