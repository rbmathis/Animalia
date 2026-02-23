using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Entomocorus;

/// <summary>
/// Abstract class for Entomocorus (genus).
/// NCBI TaxId: 2382288
/// </summary>
public abstract class Entomocorus : Auchenipteridae, IEntomocorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Entomocorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2382288;

    /// <inheritdoc />
    public virtual string GenusName => "Entomocorus";

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
