using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Macrhybopsis;

/// <summary>
/// Abstract class for Macrhybopsis (genus).
/// NCBI TaxId: 85567
/// </summary>
public abstract class Macrhybopsis : Leuciscidae, IMacrhybopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrhybopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85567;

    /// <inheritdoc />
    public virtual string GenusName => "Macrhybopsis";

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
