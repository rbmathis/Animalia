using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Cryptonanus;

/// <summary>
/// Abstract class for Cryptonanus (genus).
/// NCBI TaxId: 320553
/// </summary>
public abstract class Cryptonanus : Didelphidae, ICryptonanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptonanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320553;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptonanus";

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
