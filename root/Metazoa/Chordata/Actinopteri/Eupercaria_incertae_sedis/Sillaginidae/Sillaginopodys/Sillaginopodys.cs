using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginopodys;

/// <summary>
/// Abstract class for Sillaginopodys (genus).
/// NCBI TaxId: 2725811
/// </summary>
public abstract class Sillaginopodys : Sillaginidae, ISillaginopodys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sillaginopodys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2725811;

    /// <inheritdoc />
    public virtual string GenusName => "Sillaginopodys";

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
