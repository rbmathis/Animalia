using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Genyonemus;

/// <summary>
/// Abstract class for Genyonemus (genus).
/// NCBI TaxId: 320394
/// </summary>
public abstract class Genyonemus : Sciaenidae, IGenyonemus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyonemus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320394;

    /// <inheritdoc />
    public virtual string GenusName => "Genyonemus";

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
