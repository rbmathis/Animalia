using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginodes;

/// <summary>
/// Abstract class for Sillaginodes (genus).
/// NCBI TaxId: 135775
/// </summary>
public abstract class Sillaginodes : Sillaginidae, ISillaginodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sillaginodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135775;

    /// <inheritdoc />
    public virtual string GenusName => "Sillaginodes";

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
