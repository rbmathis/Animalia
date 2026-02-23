using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Molidae.Ranzania;

/// <summary>
/// Abstract class for Ranzania (genus).
/// NCBI TaxId: 210586
/// </summary>
public abstract class Ranzania : Molidae, IRanzania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ranzania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210586;

    /// <inheritdoc />
    public virtual string GenusName => "Ranzania";

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
