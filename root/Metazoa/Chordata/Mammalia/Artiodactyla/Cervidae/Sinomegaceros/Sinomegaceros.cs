using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Sinomegaceros;

/// <summary>
/// Abstract class for Sinomegaceros (genus).
/// NCBI TaxId: 3104227
/// </summary>
public abstract class Sinomegaceros : Cervidae, ISinomegaceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinomegaceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3104227;

    /// <inheritdoc />
    public virtual string GenusName => "Sinomegaceros";

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
