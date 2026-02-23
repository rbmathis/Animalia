using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Craugastoridae.Noblella;

/// <summary>
/// Abstract class for Noblella (genus).
/// NCBI TaxId: 611797
/// </summary>
public abstract class Noblella : Craugastoridae, INoblella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Noblella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 611797;

    /// <inheritdoc />
    public virtual string GenusName => "Noblella";

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
