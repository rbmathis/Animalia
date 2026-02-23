using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tilapia;

/// <summary>
/// Abstract class for Tilapia (genus).
/// NCBI TaxId: 8126
/// </summary>
public abstract class Tilapia : Cichlidae, ITilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8126;

    /// <inheritdoc />
    public virtual string GenusName => "Tilapia";

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
