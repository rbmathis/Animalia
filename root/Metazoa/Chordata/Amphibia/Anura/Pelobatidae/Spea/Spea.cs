using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelobatidae.Spea;

/// <summary>
/// Abstract class for Spea (genus).
/// NCBI TaxId: 30316
/// </summary>
public abstract class Spea : Pelobatidae, ISpea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30316;

    /// <inheritdoc />
    public virtual string GenusName => "Spea";

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
