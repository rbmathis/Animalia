using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Acanthuridae.Zebrasoma;

/// <summary>
/// Abstract class for Zebrasoma (genus).
/// NCBI TaxId: 75045
/// </summary>
public abstract class Zebrasoma : Acanthuridae, IZebrasoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zebrasoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75045;

    /// <inheritdoc />
    public virtual string GenusName => "Zebrasoma";

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
