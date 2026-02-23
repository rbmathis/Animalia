using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Formicarius;

/// <summary>
/// Abstract class for Formicarius (genus).
/// NCBI TaxId: 81883
/// </summary>
public abstract class Formicarius : Formicariidae, IFormicarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Formicarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81883;

    /// <inheritdoc />
    public virtual string GenusName => "Formicarius";

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
