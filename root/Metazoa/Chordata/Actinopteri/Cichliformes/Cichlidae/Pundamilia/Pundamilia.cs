using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pundamilia;

/// <summary>
/// Abstract class for Pundamilia (genus).
/// NCBI TaxId: 195936
/// </summary>
public abstract class Pundamilia : Cichlidae, IPundamilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pundamilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195936;

    /// <inheritdoc />
    public virtual string GenusName => "Pundamilia";

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
