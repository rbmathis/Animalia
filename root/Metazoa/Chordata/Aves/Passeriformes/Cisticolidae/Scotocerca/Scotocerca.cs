using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Scotocerca;

/// <summary>
/// Abstract class for Scotocerca (genus).
/// NCBI TaxId: 117182
/// </summary>
public abstract class Scotocerca : Cisticolidae, IScotocerca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotocerca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117182;

    /// <inheritdoc />
    public virtual string GenusName => "Scotocerca";

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
