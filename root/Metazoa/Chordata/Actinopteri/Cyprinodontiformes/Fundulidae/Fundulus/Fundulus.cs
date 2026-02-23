using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fundulidae.Fundulus;

/// <summary>
/// Abstract class for Fundulus (genus).
/// NCBI TaxId: 8077
/// </summary>
public abstract class Fundulus : Fundulidae, IFundulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fundulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8077;

    /// <inheritdoc />
    public virtual string GenusName => "Fundulus";

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
