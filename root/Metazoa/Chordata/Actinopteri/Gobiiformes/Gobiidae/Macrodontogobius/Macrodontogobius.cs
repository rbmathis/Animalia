using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Macrodontogobius;

/// <summary>
/// Abstract class for Macrodontogobius (genus).
/// NCBI TaxId: 1647187
/// </summary>
public abstract class Macrodontogobius : Gobiidae, IMacrodontogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrodontogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647187;

    /// <inheritdoc />
    public virtual string GenusName => "Macrodontogobius";

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
