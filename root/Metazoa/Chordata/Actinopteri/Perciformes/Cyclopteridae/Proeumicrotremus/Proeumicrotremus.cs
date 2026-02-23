using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cyclopteridae.Proeumicrotremus;

/// <summary>
/// Abstract class for Proeumicrotremus (genus).
/// NCBI TaxId: 3363464
/// </summary>
public abstract class Proeumicrotremus : Cyclopteridae, IProeumicrotremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proeumicrotremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363464;

    /// <inheritdoc />
    public virtual string GenusName => "Proeumicrotremus";

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
