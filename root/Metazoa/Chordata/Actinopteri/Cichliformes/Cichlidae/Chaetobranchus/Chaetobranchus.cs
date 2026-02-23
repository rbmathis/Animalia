using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chaetobranchus;

/// <summary>
/// Abstract class for Chaetobranchus (genus).
/// NCBI TaxId: 74105
/// </summary>
public abstract class Chaetobranchus : Cichlidae, IChaetobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74105;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetobranchus";

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
