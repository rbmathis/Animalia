using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Vieja;

/// <summary>
/// Abstract class for Vieja (genus).
/// NCBI TaxId: 2083494
/// </summary>
public abstract class Vieja : Cichlidae, IVieja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vieja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2083494;

    /// <inheritdoc />
    public virtual string GenusName => "Vieja";

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
