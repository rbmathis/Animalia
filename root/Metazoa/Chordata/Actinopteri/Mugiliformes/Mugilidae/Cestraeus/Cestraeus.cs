using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Cestraeus;

/// <summary>
/// Abstract class for Cestraeus (genus).
/// NCBI TaxId: 1040946
/// </summary>
public abstract class Cestraeus : Mugilidae, ICestraeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cestraeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1040946;

    /// <inheritdoc />
    public virtual string GenusName => "Cestraeus";

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
