using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae.Siniperca;

/// <summary>
/// Abstract class for Siniperca (genus).
/// NCBI TaxId: 119487
/// </summary>
public abstract class Siniperca : Sinipercidae, ISiniperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Siniperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119487;

    /// <inheritdoc />
    public virtual string GenusName => "Siniperca";

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
