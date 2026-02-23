using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Ulaema;

/// <summary>
/// Abstract class for Ulaema (genus).
/// NCBI TaxId: 1206947
/// </summary>
public abstract class Ulaema : Gerreidae, IUlaema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ulaema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1206947;

    /// <inheritdoc />
    public virtual string GenusName => "Ulaema";

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
