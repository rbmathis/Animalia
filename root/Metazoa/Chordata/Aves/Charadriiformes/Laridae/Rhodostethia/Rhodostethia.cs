using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Rhodostethia;

/// <summary>
/// Abstract class for Rhodostethia (genus).
/// NCBI TaxId: 328016
/// </summary>
public abstract class Rhodostethia : Laridae, IRhodostethia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodostethia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 328016;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodostethia";

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
