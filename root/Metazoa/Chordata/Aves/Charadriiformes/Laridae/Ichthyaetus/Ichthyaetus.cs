using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Ichthyaetus;

/// <summary>
/// Abstract class for Ichthyaetus (genus).
/// NCBI TaxId: 1288289
/// </summary>
public abstract class Ichthyaetus : Laridae, IIchthyaetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyaetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1288289;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyaetus";

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
