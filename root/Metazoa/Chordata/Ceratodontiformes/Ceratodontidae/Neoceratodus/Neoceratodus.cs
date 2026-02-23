using AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Ceratodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ceratodontiformes.Ceratodontidae.Neoceratodus;

/// <summary>
/// Abstract class for Neoceratodus (genus).
/// NCBI TaxId: 7890
/// </summary>
public abstract class Neoceratodus : Ceratodontidae, INeoceratodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoceratodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7890;

    /// <inheritdoc />
    public virtual string GenusName => "Neoceratodus";

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
