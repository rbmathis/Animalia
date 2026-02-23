using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Taeniacara;

/// <summary>
/// Abstract class for Taeniacara (genus).
/// NCBI TaxId: 97001
/// </summary>
public abstract class Taeniacara : Cichlidae, ITaeniacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taeniacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 97001;

    /// <inheritdoc />
    public virtual string GenusName => "Taeniacara";

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
