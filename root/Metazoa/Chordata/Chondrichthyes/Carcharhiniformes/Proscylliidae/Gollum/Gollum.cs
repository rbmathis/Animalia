using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Proscylliidae.Gollum;

/// <summary>
/// Abstract class for Gollum (genus).
/// NCBI TaxId: 376636
/// </summary>
public abstract class Gollum : Proscylliidae, IGollum
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gollum";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376636;

    /// <inheritdoc />
    public virtual string GenusName => "Gollum";

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
