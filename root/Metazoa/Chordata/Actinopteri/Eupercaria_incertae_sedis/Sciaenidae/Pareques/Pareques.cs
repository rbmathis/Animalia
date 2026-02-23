using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Pareques;

/// <summary>
/// Abstract class for Pareques (genus).
/// NCBI TaxId: 587066
/// </summary>
public abstract class Pareques : Sciaenidae, IPareques
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareques";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587066;

    /// <inheritdoc />
    public virtual string GenusName => "Pareques";

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
