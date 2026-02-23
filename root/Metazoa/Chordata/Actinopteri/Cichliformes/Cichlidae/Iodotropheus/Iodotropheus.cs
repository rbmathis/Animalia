using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Iodotropheus;

/// <summary>
/// Abstract class for Iodotropheus (genus).
/// NCBI TaxId: 57304
/// </summary>
public abstract class Iodotropheus : Cichlidae, IIodotropheus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iodotropheus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57304;

    /// <inheritdoc />
    public virtual string GenusName => "Iodotropheus";

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
