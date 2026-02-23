using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Percophis;

/// <summary>
/// Abstract class for Percophis (genus).
/// NCBI TaxId: 443801
/// </summary>
public abstract class Percophis : Percophidae, IPercophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443801;

    /// <inheritdoc />
    public virtual string GenusName => "Percophis";

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
