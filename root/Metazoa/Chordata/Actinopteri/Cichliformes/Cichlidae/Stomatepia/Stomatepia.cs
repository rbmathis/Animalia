using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Stomatepia;

/// <summary>
/// Abstract class for Stomatepia (genus).
/// NCBI TaxId: 143645
/// </summary>
public abstract class Stomatepia : Cichlidae, IStomatepia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stomatepia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143645;

    /// <inheritdoc />
    public virtual string GenusName => "Stomatepia";

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
