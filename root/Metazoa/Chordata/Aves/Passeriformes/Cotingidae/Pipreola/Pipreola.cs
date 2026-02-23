using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Pipreola;

/// <summary>
/// Abstract class for Pipreola (genus).
/// NCBI TaxId: 114365
/// </summary>
public abstract class Pipreola : Cotingidae, IPipreola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipreola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114365;

    /// <inheritdoc />
    public virtual string GenusName => "Pipreola";

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
