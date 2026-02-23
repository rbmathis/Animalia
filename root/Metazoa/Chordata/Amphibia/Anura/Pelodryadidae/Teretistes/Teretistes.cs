using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Teretistes;

/// <summary>
/// Abstract class for Teretistes (genus).
/// NCBI TaxId: 3681010
/// </summary>
public abstract class Teretistes : Pelodryadidae, ITeretistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teretistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681010;

    /// <inheritdoc />
    public virtual string GenusName => "Teretistes";

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
