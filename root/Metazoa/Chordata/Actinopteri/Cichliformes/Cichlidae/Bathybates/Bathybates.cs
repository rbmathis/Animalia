using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Bathybates;

/// <summary>
/// Abstract class for Bathybates (genus).
/// NCBI TaxId: 27732
/// </summary>
public abstract class Bathybates : Cichlidae, IBathybates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathybates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27732;

    /// <inheritdoc />
    public virtual string GenusName => "Bathybates";

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
