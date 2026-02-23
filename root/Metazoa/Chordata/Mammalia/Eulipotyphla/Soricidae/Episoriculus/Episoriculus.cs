using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Episoriculus;

/// <summary>
/// Abstract class for Episoriculus (genus).
/// NCBI TaxId: 269272
/// </summary>
public abstract class Episoriculus : Soricidae, IEpisoriculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Episoriculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 269272;

    /// <inheritdoc />
    public virtual string GenusName => "Episoriculus";

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
