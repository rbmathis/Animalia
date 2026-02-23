using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Nectariniidae.Promerops;

/// <summary>
/// Abstract class for Promerops (genus).
/// NCBI TaxId: 254651
/// </summary>
public abstract class Promerops : Nectariniidae, IPromerops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Promerops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254651;

    /// <inheritdoc />
    public virtual string GenusName => "Promerops";

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
