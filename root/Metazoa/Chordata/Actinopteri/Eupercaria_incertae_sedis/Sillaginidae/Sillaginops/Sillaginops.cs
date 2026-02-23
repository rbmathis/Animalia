using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginops;

/// <summary>
/// Abstract class for Sillaginops (genus).
/// NCBI TaxId: 2705311
/// </summary>
public abstract class Sillaginops : Sillaginidae, ISillaginops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sillaginops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2705311;

    /// <inheritdoc />
    public virtual string GenusName => "Sillaginops";

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
