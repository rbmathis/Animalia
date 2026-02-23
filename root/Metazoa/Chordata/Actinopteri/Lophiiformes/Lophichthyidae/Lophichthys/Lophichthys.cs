using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophichthyidae.Lophichthys;

/// <summary>
/// Abstract class for Lophichthys (genus).
/// NCBI TaxId: 1489934
/// </summary>
public abstract class Lophichthys : Lophichthyidae, ILophichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1489934;

    /// <inheritdoc />
    public virtual string GenusName => "Lophichthys";

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
