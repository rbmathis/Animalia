using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Upucerthia;

/// <summary>
/// Abstract class for Upucerthia (genus).
/// NCBI TaxId: 183160
/// </summary>
public abstract class Upucerthia : Furnariidae, IUpucerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Upucerthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183160;

    /// <inheritdoc />
    public virtual string GenusName => "Upucerthia";

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
