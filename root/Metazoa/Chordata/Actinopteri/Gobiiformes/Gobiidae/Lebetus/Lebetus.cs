using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Lebetus;

/// <summary>
/// Abstract class for Lebetus (genus).
/// NCBI TaxId: 1365693
/// </summary>
public abstract class Lebetus : Gobiidae, ILebetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lebetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1365693;

    /// <inheritdoc />
    public virtual string GenusName => "Lebetus";

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
