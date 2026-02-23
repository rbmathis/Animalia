using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Metachirus;

/// <summary>
/// Abstract class for Metachirus (genus).
/// NCBI TaxId: 42724
/// </summary>
public abstract class Metachirus : Didelphidae, IMetachirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metachirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42724;

    /// <inheritdoc />
    public virtual string GenusName => "Metachirus";

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
