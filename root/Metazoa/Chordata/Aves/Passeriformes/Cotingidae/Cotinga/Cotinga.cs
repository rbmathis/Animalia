using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Cotinga;

/// <summary>
/// Abstract class for Cotinga (genus).
/// NCBI TaxId: 114293
/// </summary>
public abstract class Cotinga : Cotingidae, ICotinga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cotinga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114293;

    /// <inheritdoc />
    public virtual string GenusName => "Cotinga";

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
