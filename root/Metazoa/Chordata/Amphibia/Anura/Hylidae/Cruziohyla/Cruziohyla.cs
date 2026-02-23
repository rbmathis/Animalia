using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Cruziohyla;

/// <summary>
/// Abstract class for Cruziohyla (genus).
/// NCBI TaxId: 374087
/// </summary>
public abstract class Cruziohyla : Hylidae, ICruziohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cruziohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374087;

    /// <inheritdoc />
    public virtual string GenusName => "Cruziohyla";

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
