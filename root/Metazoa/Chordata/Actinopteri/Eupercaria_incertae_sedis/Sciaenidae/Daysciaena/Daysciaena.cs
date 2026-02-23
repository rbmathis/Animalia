using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Daysciaena;

/// <summary>
/// Abstract class for Daysciaena (genus).
/// NCBI TaxId: 1642207
/// </summary>
public abstract class Daysciaena : Sciaenidae, IDaysciaena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daysciaena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1642207;

    /// <inheritdoc />
    public virtual string GenusName => "Daysciaena";

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
