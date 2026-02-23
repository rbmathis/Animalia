using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Larus;

/// <summary>
/// Abstract class for Larus (genus).
/// NCBI TaxId: 8911
/// </summary>
public abstract class Larus : Laridae, ILarus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Larus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8911;

    /// <inheritdoc />
    public virtual string GenusName => "Larus";

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
