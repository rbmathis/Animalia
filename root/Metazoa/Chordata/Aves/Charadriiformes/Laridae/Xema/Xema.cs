using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Xema;

/// <summary>
/// Abstract class for Xema (genus).
/// NCBI TaxId: 128049
/// </summary>
public abstract class Xema : Laridae, IXema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 128049;

    /// <inheritdoc />
    public virtual string GenusName => "Xema";

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
