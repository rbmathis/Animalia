using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Coelophrys;

/// <summary>
/// Abstract class for Coelophrys (genus).
/// NCBI TaxId: 412624
/// </summary>
public abstract class Coelophrys : Ogcocephalidae, ICoelophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 412624;

    /// <inheritdoc />
    public virtual string GenusName => "Coelophrys";

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
