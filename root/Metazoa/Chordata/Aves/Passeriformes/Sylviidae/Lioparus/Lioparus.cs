using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Lioparus;

/// <summary>
/// Abstract class for Lioparus (genus).
/// NCBI TaxId: 2183876
/// </summary>
public abstract class Lioparus : Sylviidae, ILioparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lioparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2183876;

    /// <inheritdoc />
    public virtual string GenusName => "Lioparus";

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
