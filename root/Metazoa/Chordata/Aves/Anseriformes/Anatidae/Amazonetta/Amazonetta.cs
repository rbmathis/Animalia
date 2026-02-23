using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Amazonetta;

/// <summary>
/// Abstract class for Amazonetta (genus).
/// NCBI TaxId: 75866
/// </summary>
public abstract class Amazonetta : Anatidae, IAmazonetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amazonetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75866;

    /// <inheritdoc />
    public virtual string GenusName => "Amazonetta";

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
