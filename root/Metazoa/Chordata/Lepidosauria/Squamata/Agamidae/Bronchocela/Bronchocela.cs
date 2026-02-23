using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Bronchocela;

/// <summary>
/// Abstract class for Bronchocela (genus).
/// NCBI TaxId: 118089
/// </summary>
public abstract class Bronchocela : Agamidae, IBronchocela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bronchocela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118089;

    /// <inheritdoc />
    public virtual string GenusName => "Bronchocela";

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
