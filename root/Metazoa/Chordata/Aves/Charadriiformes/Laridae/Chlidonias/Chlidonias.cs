using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Chlidonias;

/// <summary>
/// Abstract class for Chlidonias (genus).
/// NCBI TaxId: 279944
/// </summary>
public abstract class Chlidonias : Laridae, IChlidonias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlidonias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 279944;

    /// <inheritdoc />
    public virtual string GenusName => "Chlidonias";

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
