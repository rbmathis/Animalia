using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Camelidae.Lama;

/// <summary>
/// Abstract class for Lama (genus).
/// NCBI TaxId: 9839
/// </summary>
public abstract class Lama : Camelidae, ILama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9839;

    /// <inheritdoc />
    public virtual string GenusName => "Lama";

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
