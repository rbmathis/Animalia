using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Leucophaeus;

/// <summary>
/// Abstract class for Leucophaeus (genus).
/// NCBI TaxId: 328018
/// </summary>
public abstract class Leucophaeus : Laridae, ILeucophaeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leucophaeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328018;

    /// <inheritdoc />
    public virtual string GenusName => "Leucophaeus";

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
