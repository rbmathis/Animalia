using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Schedophilus;

/// <summary>
/// Abstract class for Schedophilus (genus).
/// NCBI TaxId: 316131
/// </summary>
public abstract class Schedophilus : Centrolophidae, ISchedophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schedophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316131;

    /// <inheritdoc />
    public virtual string GenusName => "Schedophilus";

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
