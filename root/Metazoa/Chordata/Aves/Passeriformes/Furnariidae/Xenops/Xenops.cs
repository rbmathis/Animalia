using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Xenops;

/// <summary>
/// Abstract class for Xenops (genus).
/// NCBI TaxId: 255385
/// </summary>
public abstract class Xenops : Furnariidae, IXenops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 255385;

    /// <inheritdoc />
    public virtual string GenusName => "Xenops";

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
