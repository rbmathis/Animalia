using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Pekania;

/// <summary>
/// Abstract class for Pekania (genus).
/// NCBI TaxId: 2892070
/// </summary>
public abstract class Pekania : Mustelidae, IPekania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pekania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2892070;

    /// <inheritdoc />
    public virtual string GenusName => "Pekania";

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
