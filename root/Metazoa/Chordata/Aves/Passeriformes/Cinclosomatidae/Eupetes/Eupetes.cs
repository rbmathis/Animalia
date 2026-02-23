using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Eupetes;

/// <summary>
/// Abstract class for Eupetes (genus).
/// NCBI TaxId: 449351
/// </summary>
public abstract class Eupetes : Cinclosomatidae, IEupetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 449351;

    /// <inheritdoc />
    public virtual string GenusName => "Eupetes";

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
