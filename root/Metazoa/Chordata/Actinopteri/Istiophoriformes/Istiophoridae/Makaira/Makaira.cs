using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Istiophoriformes.Istiophoridae.Makaira;

/// <summary>
/// Abstract class for Makaira (genus).
/// NCBI TaxId: 13602
/// </summary>
public abstract class Makaira : Istiophoridae, IMakaira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Makaira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13602;

    /// <inheritdoc />
    public virtual string GenusName => "Makaira";

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
