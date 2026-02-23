using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Charadriidae.Oreopholus;

/// <summary>
/// Abstract class for Oreopholus (genus).
/// NCBI TaxId: 50407
/// </summary>
public abstract class Oreopholus : Charadriidae, IOreopholus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreopholus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50407;

    /// <inheritdoc />
    public virtual string GenusName => "Oreopholus";

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
