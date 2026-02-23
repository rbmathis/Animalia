using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Limnotilapia;

/// <summary>
/// Abstract class for Limnotilapia (genus).
/// NCBI TaxId: 244510
/// </summary>
public abstract class Limnotilapia : Cichlidae, ILimnotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 244510;

    /// <inheritdoc />
    public virtual string GenusName => "Limnotilapia";

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
