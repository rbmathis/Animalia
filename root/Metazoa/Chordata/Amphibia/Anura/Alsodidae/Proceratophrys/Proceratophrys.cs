using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Proceratophrys;

/// <summary>
/// Abstract class for Proceratophrys (genus).
/// NCBI TaxId: 209678
/// </summary>
public abstract class Proceratophrys : Alsodidae, IProceratophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proceratophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209678;

    /// <inheritdoc />
    public virtual string GenusName => "Proceratophrys";

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
