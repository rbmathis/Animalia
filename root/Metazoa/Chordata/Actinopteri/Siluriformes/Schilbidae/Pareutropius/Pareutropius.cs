using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Pareutropius;

/// <summary>
/// Abstract class for Pareutropius (genus).
/// NCBI TaxId: 390427
/// </summary>
public abstract class Pareutropius : Schilbidae, IPareutropius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareutropius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390427;

    /// <inheritdoc />
    public virtual string GenusName => "Pareutropius";

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
