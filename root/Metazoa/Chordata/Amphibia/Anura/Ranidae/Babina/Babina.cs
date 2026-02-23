using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Babina;

/// <summary>
/// Abstract class for Babina (genus).
/// NCBI TaxId: 1208378
/// </summary>
public abstract class Babina : Ranidae, IBabina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Babina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208378;

    /// <inheritdoc />
    public virtual string GenusName => "Babina";

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
