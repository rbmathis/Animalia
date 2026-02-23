using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Pseudetroplus;

/// <summary>
/// Abstract class for Pseudetroplus (genus).
/// NCBI TaxId: 2926660
/// </summary>
public abstract class Pseudetroplus : Cichlidae, IPseudetroplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudetroplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2926660;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudetroplus";

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
