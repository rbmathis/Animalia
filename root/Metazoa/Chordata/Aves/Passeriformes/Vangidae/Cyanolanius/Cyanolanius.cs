using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Cyanolanius;

/// <summary>
/// Abstract class for Cyanolanius (genus).
/// NCBI TaxId: 125271
/// </summary>
public abstract class Cyanolanius : Vangidae, ICyanolanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanolanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125271;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanolanius";

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
