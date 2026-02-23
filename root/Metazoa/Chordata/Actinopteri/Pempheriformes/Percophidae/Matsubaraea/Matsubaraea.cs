using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Matsubaraea;

/// <summary>
/// Abstract class for Matsubaraea (genus).
/// NCBI TaxId: 1633521
/// </summary>
public abstract class Matsubaraea : Percophidae, IMatsubaraea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Matsubaraea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633521;

    /// <inheritdoc />
    public virtual string GenusName => "Matsubaraea";

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
