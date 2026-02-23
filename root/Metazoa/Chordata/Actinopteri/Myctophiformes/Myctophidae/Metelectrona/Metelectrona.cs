using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Myctophiformes.Myctophidae.Metelectrona;

/// <summary>
/// Abstract class for Metelectrona (genus).
/// NCBI TaxId: 1003959
/// </summary>
public abstract class Metelectrona : Myctophidae, IMetelectrona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metelectrona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003959;

    /// <inheritdoc />
    public virtual string GenusName => "Metelectrona";

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
