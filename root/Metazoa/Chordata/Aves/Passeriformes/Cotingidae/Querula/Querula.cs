using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Querula;

/// <summary>
/// Abstract class for Querula (genus).
/// NCBI TaxId: 114377
/// </summary>
public abstract class Querula : Cotingidae, IQuerula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Querula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114377;

    /// <inheritdoc />
    public virtual string GenusName => "Querula";

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
