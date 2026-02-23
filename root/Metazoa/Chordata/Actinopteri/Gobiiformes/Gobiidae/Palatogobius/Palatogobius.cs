using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Palatogobius;

/// <summary>
/// Abstract class for Palatogobius (genus).
/// NCBI TaxId: 2008635
/// </summary>
public abstract class Palatogobius : Gobiidae, IPalatogobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palatogobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2008635;

    /// <inheritdoc />
    public virtual string GenusName => "Palatogobius";

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
