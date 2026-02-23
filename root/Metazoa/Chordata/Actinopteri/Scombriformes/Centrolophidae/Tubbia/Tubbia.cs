using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Tubbia;

/// <summary>
/// Abstract class for Tubbia (genus).
/// NCBI TaxId: 334876
/// </summary>
public abstract class Tubbia : Centrolophidae, ITubbia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tubbia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334876;

    /// <inheritdoc />
    public virtual string GenusName => "Tubbia";

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
