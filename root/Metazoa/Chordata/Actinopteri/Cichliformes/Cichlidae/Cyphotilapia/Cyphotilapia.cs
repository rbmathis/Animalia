using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cyphotilapia;

/// <summary>
/// Abstract class for Cyphotilapia (genus).
/// NCBI TaxId: 27782
/// </summary>
public abstract class Cyphotilapia : Cichlidae, ICyphotilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyphotilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27782;

    /// <inheritdoc />
    public virtual string GenusName => "Cyphotilapia";

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
