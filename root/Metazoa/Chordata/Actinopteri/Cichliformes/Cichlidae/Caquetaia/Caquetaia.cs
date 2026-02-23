using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Caquetaia;

/// <summary>
/// Abstract class for Caquetaia (genus).
/// NCBI TaxId: 63164
/// </summary>
public abstract class Caquetaia : Cichlidae, ICaquetaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caquetaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63164;

    /// <inheritdoc />
    public virtual string GenusName => "Caquetaia";

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
