using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Incana;

/// <summary>
/// Abstract class for Incana (genus).
/// NCBI TaxId: 405077
/// </summary>
public abstract class Incana : Cisticolidae, IIncana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Incana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405077;

    /// <inheritdoc />
    public virtual string GenusName => "Incana";

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
