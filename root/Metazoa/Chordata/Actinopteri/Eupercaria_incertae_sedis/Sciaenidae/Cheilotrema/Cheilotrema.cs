using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Cheilotrema;

/// <summary>
/// Abstract class for Cheilotrema (genus).
/// NCBI TaxId: 320391
/// </summary>
public abstract class Cheilotrema : Sciaenidae, ICheilotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320391;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilotrema";

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
