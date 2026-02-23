using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mbipia;

/// <summary>
/// Abstract class for Mbipia (genus).
/// NCBI TaxId: 336467
/// </summary>
public abstract class Mbipia : Cichlidae, IMbipia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mbipia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 336467;

    /// <inheritdoc />
    public virtual string GenusName => "Mbipia";

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
