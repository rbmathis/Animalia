using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Arremon;

/// <summary>
/// Abstract class for Arremon (genus).
/// NCBI TaxId: 241749
/// </summary>
public abstract class Arremon : Passerellidae, IArremon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arremon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241749;

    /// <inheritdoc />
    public virtual string GenusName => "Arremon";

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
