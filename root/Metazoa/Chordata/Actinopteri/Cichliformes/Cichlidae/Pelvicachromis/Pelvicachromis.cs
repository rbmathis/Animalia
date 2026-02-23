using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pelvicachromis;

/// <summary>
/// Abstract class for Pelvicachromis (genus).
/// NCBI TaxId: 28826
/// </summary>
public abstract class Pelvicachromis : Cichlidae, IPelvicachromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelvicachromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28826;

    /// <inheritdoc />
    public virtual string GenusName => "Pelvicachromis";

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
