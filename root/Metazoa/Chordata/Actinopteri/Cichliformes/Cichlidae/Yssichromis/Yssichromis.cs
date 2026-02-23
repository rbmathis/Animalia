using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Yssichromis;

/// <summary>
/// Abstract class for Yssichromis (genus).
/// NCBI TaxId: 51181
/// </summary>
public abstract class Yssichromis : Cichlidae, IYssichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yssichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51181;

    /// <inheritdoc />
    public virtual string GenusName => "Yssichromis";

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
