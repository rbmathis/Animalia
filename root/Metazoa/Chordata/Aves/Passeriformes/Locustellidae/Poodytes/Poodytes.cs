using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Poodytes;

/// <summary>
/// Abstract class for Poodytes (genus).
/// NCBI TaxId: 2163166
/// </summary>
public abstract class Poodytes : Locustellidae, IPoodytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poodytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2163166;

    /// <inheritdoc />
    public virtual string GenusName => "Poodytes";

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
