using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Eugnathogobius;

/// <summary>
/// Abstract class for Eugnathogobius (genus).
/// NCBI TaxId: 150321
/// </summary>
public abstract class Eugnathogobius : Gobiidae, IEugnathogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eugnathogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150321;

    /// <inheritdoc />
    public virtual string GenusName => "Eugnathogobius";

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
