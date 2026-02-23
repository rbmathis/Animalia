using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Sciaena;

/// <summary>
/// Abstract class for Sciaena (genus).
/// NCBI TaxId: 547151
/// </summary>
public abstract class Sciaena : Sciaenidae, ISciaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sciaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 547151;

    /// <inheritdoc />
    public virtual string GenusName => "Sciaena";

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
