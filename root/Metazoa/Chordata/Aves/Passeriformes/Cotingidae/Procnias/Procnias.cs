using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Procnias;

/// <summary>
/// Abstract class for Procnias (genus).
/// NCBI TaxId: 114372
/// </summary>
public abstract class Procnias : Cotingidae, IProcnias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Procnias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114372;

    /// <inheritdoc />
    public virtual string GenusName => "Procnias";

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
