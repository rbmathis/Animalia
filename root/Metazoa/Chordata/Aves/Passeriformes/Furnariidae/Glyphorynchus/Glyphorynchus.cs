using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Glyphorynchus;

/// <summary>
/// Abstract class for Glyphorynchus (genus).
/// NCBI TaxId: 135973
/// </summary>
public abstract class Glyphorynchus : Furnariidae, IGlyphorynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glyphorynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135973;

    /// <inheritdoc />
    public virtual string GenusName => "Glyphorynchus";

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
