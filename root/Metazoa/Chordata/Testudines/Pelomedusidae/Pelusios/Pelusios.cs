using AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Pelomedusidae.Pelusios;

/// <summary>
/// Abstract class for Pelusios (genus).
/// NCBI TaxId: 44525
/// </summary>
public abstract class Pelusios : Pelomedusidae, IPelusios
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelusios";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44525;

    /// <inheritdoc />
    public virtual string GenusName => "Pelusios";

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
