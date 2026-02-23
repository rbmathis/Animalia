using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Amaralia;

/// <summary>
/// Abstract class for Amaralia (genus).
/// NCBI TaxId: 385282
/// </summary>
public abstract class Amaralia : Aspredinidae, IAmaralia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amaralia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385282;

    /// <inheritdoc />
    public virtual string GenusName => "Amaralia";

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
