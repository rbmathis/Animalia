using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Recurvirostridae.Himantopus;

/// <summary>
/// Abstract class for Himantopus (genus).
/// NCBI TaxId: 225397
/// </summary>
public abstract class Himantopus : Recurvirostridae, IHimantopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Himantopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 225397;

    /// <inheritdoc />
    public virtual string GenusName => "Himantopus";

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
