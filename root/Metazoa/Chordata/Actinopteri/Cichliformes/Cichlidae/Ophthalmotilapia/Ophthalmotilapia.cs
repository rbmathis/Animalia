using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ophthalmotilapia;

/// <summary>
/// Abstract class for Ophthalmotilapia (genus).
/// NCBI TaxId: 27754
/// </summary>
public abstract class Ophthalmotilapia : Cichlidae, IOphthalmotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophthalmotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27754;

    /// <inheritdoc />
    public virtual string GenusName => "Ophthalmotilapia";

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
