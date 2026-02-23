using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Onychoprion;

/// <summary>
/// Abstract class for Onychoprion (genus).
/// NCBI TaxId: 425647
/// </summary>
public abstract class Onychoprion : Laridae, IOnychoprion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onychoprion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425647;

    /// <inheritdoc />
    public virtual string GenusName => "Onychoprion";

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
