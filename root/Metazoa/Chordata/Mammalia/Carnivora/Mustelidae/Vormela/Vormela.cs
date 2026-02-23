using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Vormela;

/// <summary>
/// Abstract class for Vormela (genus).
/// NCBI TaxId: 300626
/// </summary>
public abstract class Vormela : Mustelidae, IVormela
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vormela";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 300626;

    /// <inheritdoc />
    public virtual string GenusName => "Vormela";

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
