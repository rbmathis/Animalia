using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Ancistrops;

/// <summary>
/// Abstract class for Ancistrops (genus).
/// NCBI TaxId: 589936
/// </summary>
public abstract class Ancistrops : Furnariidae, IAncistrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ancistrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589936;

    /// <inheritdoc />
    public virtual string GenusName => "Ancistrops";

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
