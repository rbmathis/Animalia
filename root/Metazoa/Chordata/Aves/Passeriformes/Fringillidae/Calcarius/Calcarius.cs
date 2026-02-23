using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Calcarius;

/// <summary>
/// Abstract class for Calcarius (genus).
/// NCBI TaxId: 135423
/// </summary>
public abstract class Calcarius : Fringillidae, ICalcarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calcarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135423;

    /// <inheritdoc />
    public virtual string GenusName => "Calcarius";

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
