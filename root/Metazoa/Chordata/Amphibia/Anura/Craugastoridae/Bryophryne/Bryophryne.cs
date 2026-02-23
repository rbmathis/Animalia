using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Bryophryne;

/// <summary>
/// Abstract class for Bryophryne (genus).
/// NCBI TaxId: 611787
/// </summary>
public abstract class Bryophryne : Craugastoridae, IBryophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bryophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 611787;

    /// <inheritdoc />
    public virtual string GenusName => "Bryophryne";

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
