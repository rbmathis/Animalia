using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Pagophila;

/// <summary>
/// Abstract class for Pagophila (genus).
/// NCBI TaxId: 126720
/// </summary>
public abstract class Pagophila : Laridae, IPagophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126720;

    /// <inheritdoc />
    public virtual string GenusName => "Pagophila";

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
