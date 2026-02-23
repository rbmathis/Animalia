using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Alionematichthys;

/// <summary>
/// Abstract class for Alionematichthys (genus).
/// NCBI TaxId: 1604645
/// </summary>
public abstract class Alionematichthys : Bythitidae, IAlionematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alionematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604645;

    /// <inheritdoc />
    public virtual string GenusName => "Alionematichthys";

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
