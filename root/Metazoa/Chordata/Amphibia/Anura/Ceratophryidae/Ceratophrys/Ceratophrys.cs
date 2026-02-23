using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Ceratophrys;

/// <summary>
/// Abstract class for Ceratophrys (genus).
/// NCBI TaxId: 30346
/// </summary>
public abstract class Ceratophrys : Ceratophryidae, ICeratophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceratophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30346;

    /// <inheritdoc />
    public virtual string GenusName => "Ceratophrys";

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
