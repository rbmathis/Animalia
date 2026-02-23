using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Cyematidae.Cyema;

/// <summary>
/// Abstract class for Cyema (genus).
/// NCBI TaxId: 556251
/// </summary>
public abstract class Cyema : Cyematidae, ICyema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556251;

    /// <inheritdoc />
    public virtual string GenusName => "Cyema";

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
