using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Copadichromis;

/// <summary>
/// Abstract class for Copadichromis (genus).
/// NCBI TaxId: 35573
/// </summary>
public abstract class Copadichromis : Cichlidae, ICopadichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Copadichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 35573;

    /// <inheritdoc />
    public virtual string GenusName => "Copadichromis";

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
