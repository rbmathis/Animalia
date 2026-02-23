using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Rissa;

/// <summary>
/// Abstract class for Rissa (genus).
/// NCBI TaxId: 70930
/// </summary>
public abstract class Rissa : Laridae, IRissa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rissa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70930;

    /// <inheritdoc />
    public virtual string GenusName => "Rissa";

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
