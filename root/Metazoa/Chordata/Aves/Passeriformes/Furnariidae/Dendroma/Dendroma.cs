using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Dendroma;

/// <summary>
/// Abstract class for Dendroma (genus).
/// NCBI TaxId: 3150789
/// </summary>
public abstract class Dendroma : Furnariidae, IDendroma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendroma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150789;

    /// <inheritdoc />
    public virtual string GenusName => "Dendroma";

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
