using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Aidablennius;

/// <summary>
/// Abstract class for Aidablennius (genus).
/// NCBI TaxId: 195072
/// </summary>
public abstract class Aidablennius : Blenniidae, IAidablennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aidablennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195072;

    /// <inheritdoc />
    public virtual string GenusName => "Aidablennius";

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
