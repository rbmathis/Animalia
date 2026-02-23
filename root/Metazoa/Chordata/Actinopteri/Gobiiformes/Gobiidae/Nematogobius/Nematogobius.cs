using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Nematogobius;

/// <summary>
/// Abstract class for Nematogobius (genus).
/// NCBI TaxId: 3362359
/// </summary>
public abstract class Nematogobius : Gobiidae, INematogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nematogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3362359;

    /// <inheritdoc />
    public virtual string GenusName => "Nematogobius";

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
