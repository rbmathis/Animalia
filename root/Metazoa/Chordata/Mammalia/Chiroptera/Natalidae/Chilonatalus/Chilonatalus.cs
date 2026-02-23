using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Chilonatalus;

/// <summary>
/// Abstract class for Chilonatalus (genus).
/// NCBI TaxId: 290567
/// </summary>
public abstract class Chilonatalus : Natalidae, IChilonatalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chilonatalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 290567;

    /// <inheritdoc />
    public virtual string GenusName => "Chilonatalus";

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
