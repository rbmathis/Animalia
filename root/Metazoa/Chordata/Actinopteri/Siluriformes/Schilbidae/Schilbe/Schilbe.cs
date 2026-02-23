using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Schilbe;

/// <summary>
/// Abstract class for Schilbe (genus).
/// NCBI TaxId: 42507
/// </summary>
public abstract class Schilbe : Schilbidae, ISchilbe
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schilbe";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42507;

    /// <inheritdoc />
    public virtual string GenusName => "Schilbe";

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
