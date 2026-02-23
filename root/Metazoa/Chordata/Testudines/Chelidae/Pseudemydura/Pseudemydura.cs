using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Pseudemydura;

/// <summary>
/// Abstract class for Pseudemydura (genus).
/// NCBI TaxId: 44509
/// </summary>
public abstract class Pseudemydura : Chelidae, IPseudemydura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudemydura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44509;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudemydura";

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
