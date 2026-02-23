using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Sclerurus;

/// <summary>
/// Abstract class for Sclerurus (genus).
/// NCBI TaxId: 183180
/// </summary>
public abstract class Sclerurus : Furnariidae, ISclerurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sclerurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183180;

    /// <inheritdoc />
    public virtual string GenusName => "Sclerurus";

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
