using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Sternula;

/// <summary>
/// Abstract class for Sternula (genus).
/// NCBI TaxId: 425655
/// </summary>
public abstract class Sternula : Laridae, ISternula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425655;

    /// <inheritdoc />
    public virtual string GenusName => "Sternula";

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
