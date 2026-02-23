using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halieutichthys;

/// <summary>
/// Abstract class for Halieutichthys (genus).
/// NCBI TaxId: 242973
/// </summary>
public abstract class Halieutichthys : Ogcocephalidae, IHalieutichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halieutichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242973;

    /// <inheritdoc />
    public virtual string GenusName => "Halieutichthys";

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
