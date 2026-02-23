using AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Bucerotiformes.Bucerotidae.Penelopides;

/// <summary>
/// Abstract class for Penelopides (genus).
/// NCBI TaxId: 175833
/// </summary>
public abstract class Penelopides : Bucerotidae, IPenelopides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Penelopides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175833;

    /// <inheritdoc />
    public virtual string GenusName => "Penelopides";

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
